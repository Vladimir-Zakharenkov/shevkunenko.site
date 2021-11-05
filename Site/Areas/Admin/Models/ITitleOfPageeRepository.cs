using System.Linq;

namespace Site.Areas.Admin.Models
{
    public interface ITitleOfPageRepository
    {
        IQueryable<TitleOfPage> TitleOfPages { get; }

        //void AddTitleOfPage(TitleOfPage titleOfPage);
    }
}
