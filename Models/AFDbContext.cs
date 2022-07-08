using Microsoft.EntityFrameworkCore;

namespace AFCentral1.Models
{
    public class AFDbContext : DbContext
    {
        public AFDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Members> Members { get; set; }

    }
}
