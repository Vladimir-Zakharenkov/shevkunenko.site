using System.Linq;

namespace Site.Areas.Admin.Models
{
    public class EFTitleOfPageRepository : ITitleOfPageRepository
    {
        private TitleOfPageContext context;
        public EFTitleOfPageRepository(TitleOfPageContext ctx)
        {
            context = ctx;
        }

        public IQueryable<TitleOfPage> TitleOfPages => context.TitleOfPages;
    }
}
