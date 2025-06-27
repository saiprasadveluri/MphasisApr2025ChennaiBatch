using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Book.Data.DB
{
    public class BookMyShowDbContextFactory : IDesignTimeDbContextFactory<BookMyShowDbContext>
    {
        public BookMyShowDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json") // make sure this file exists in the startup project
                .Build();

            var builder = new DbContextOptionsBuilder<BookMyShowDbContext>();
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            builder.UseSqlServer(connectionString);

            return new BookMyShowDbContext(builder.Options);
        }
    }
}