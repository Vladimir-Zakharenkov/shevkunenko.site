using System.Linq;

namespace Site.Models
{
    public class EFTitleOfPageRepository : ITitleOfPageRepository
    {
        private TitleOfPageDbContext context;

        public EFTitleOfPageRepository(TitleOfPageDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<TitleOfPage> TitleOfPages => context.TitleOfPages;
    }
}
