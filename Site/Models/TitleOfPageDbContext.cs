using Microsoft.EntityFrameworkCore;

namespace Site.Models
{
    public class TitleOfPageDbContext : DbContext
    {
        public TitleOfPageDbContext(DbContextOptions<TitleOfPageDbContext> options) : base(options)
        {

        }

        public DbSet<TitleOfPage> TitleOfPages { get; set; }
    }
}
