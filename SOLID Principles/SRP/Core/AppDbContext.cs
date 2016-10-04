using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace SRP.Core
{
    public class AppDbContext : DbContext
    {
        private readonly IConfigurationRoot _configuration;

        public AppDbContext(IConfigurationRoot configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration["ConnectionStrings:DefaultConnection"]);
        }
    }
}