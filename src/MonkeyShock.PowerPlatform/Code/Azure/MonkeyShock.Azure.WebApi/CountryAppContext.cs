using Microsoft.EntityFrameworkCore;

namespace MonkeyShock.Azure.WebApi
{
    public class CountryAppContext : DbContext
    {
        public DbSet<Country> Countries { get; set; }

        public CountryAppContext(DbContextOptions<CountryAppContext> options) : base(options)
        {

        }
    }
}
