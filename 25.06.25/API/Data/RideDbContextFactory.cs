using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RideAggregatorApi.Data;

namespace RideAggregatorApi
{
    public class RideDbContextFactory : IDesignTimeDbContextFactory<RideDbContext>
    {
        public RideDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<RideDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=RideAggregatorDb;Trusted_Connection=True;");

            return new RideDbContext(optionsBuilder.Options);
        }
    }
}
