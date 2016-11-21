using Microsoft.EntityFrameworkCore;

namespace Singleton.Core
{
    public class AppDbContext : DbContext
    {
        public DbSet<WebsiteMetadata> Metadata { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(AppSettings.ConnectionString);
        }
    }
}