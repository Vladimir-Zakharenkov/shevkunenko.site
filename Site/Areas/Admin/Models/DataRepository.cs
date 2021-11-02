using System.Collections.Generic;

namespace Site.Areas.Admin.Models
{
    public class DataRepository : IRepository
    {
        /* Код для временного хранения данных */

        //private List<TitleOfPage> data = new();
        //public IEnumerable<TitleOfPage> TitleOfPages => data;
        //public void AddTitleOfPage(TitleOfPage titleOfPage)
        //{
        //    this.data.Add(titleOfPage);
        //}

        /* Код для Entity Framework */

        private TitleOfPageContext context;
        public DataRepository(TitleOfPageContext ctx) => context = ctx;
        public IEnumerable<TitleOfPage> TitleOfPages => context.TitleOfPages;
        public void AddTitleOfPage(TitleOfPage titleOfPage)
        {
            context.TitleOfPages.Add(titleOfPage);
            context.SaveChanges();
        }
    }
}
