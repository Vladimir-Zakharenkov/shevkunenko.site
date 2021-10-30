using System.Collections.Generic;

namespace Site.Areas.Admin.Models
{
    public interface IRepository
    {
        IEnumerable<TitleOfPage> TitleOfPages { get; }
        void AddTitleOfPage(TitleOfPage titleOfPage);
    }
}
