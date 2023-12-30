

using Microsoft.EntityFrameworkCore;
using MyBooks.API.Data.Models;

namespace MyBooks.API.Data
{
    public class AppDbContext : DbContext
    {
        //this file will be as bridge between c# and db

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        //define table names for c# model

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
