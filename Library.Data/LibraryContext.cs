using Library.Domain.Models.Configuration;
using Library.Domain.Models.Identity;
using Library.Domain.Models.Library;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Library.Data
{
    public class LibraryContext : IdentityDbContext<User>
    {
        public LibraryContext(DbContextOptions options) : base(options) {}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }

        public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<LibraryContext>
        {
            public LibraryContext CreateDbContext(string[] args)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile(@Directory.GetCurrentDirectory()
                    + "/../Library.Web/appsettings.json").Build();

                var builder = new DbContextOptionsBuilder<LibraryContext>();
                var connectionString = configuration.GetConnectionString("DatabaseConnection");
                builder.UseSqlServer(connectionString);

                return new LibraryContext(builder.Options);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());

            modelBuilder.Entity<AuthorBook>().HasKey(t => new { t.AuthorId, t.BookId });

            modelBuilder.Entity<AuthorBook>()
                .HasOne(t => t.Author)
                .WithMany(t => t.AuthorBooks)
                .HasForeignKey(t => t.AuthorId);

            modelBuilder.Entity<AuthorBook>()
                .HasOne(t => t.Book)
                .WithMany(t => t.AuthorBooks)
                .HasForeignKey(t => t.BookId);
        }
    }
    
}
