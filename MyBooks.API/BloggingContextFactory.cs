using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using MyBooks.API.Data;

namespace MyBooks.API
{

    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseSqlServer("DefaultConnectionString");

            return new AppDbContext(optionsBuilder.Options);
        }
    }
    }

