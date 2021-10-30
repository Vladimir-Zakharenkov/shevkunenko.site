using System.Collections.Generic;

namespace Site.Areas.Admin.Models
{
    public class DataRepository : IRepository
    {
        private List<TitleOfPage> data = new();
        public IEnumerable<TitleOfPage> TitleOfPages => data;
        public void AddTitleOfPage(TitleOfPage titleOfPage)
        {
            this.data.Add(titleOfPage);
        }
    }
}
