using Microsoft.EntityFrameworkCore;

namespace Site.Areas.Admin.Models
{
    public class TitleOfPageContext : DbContext
    {
        public TitleOfPageContext(DbContextOptions<TitleOfPageContext> options) : base(options)
        {
        }

        public DbSet<TitleOfPage> TitleOfPages { get; set; }
    }
}
