using System.Collections.Generic;
using System.Linq;

namespace Site.Areas.Admin.Models
{
    public class DataRepository : ITitleOfPageRepository
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
        //public IQueryable<TitleOfPage> TitleOfPages => context.TitleOfPages.ToArray();

        IQueryable<TitleOfPage> ITitleOfPageRepository.TitleOfPages => throw new System.NotImplementedException();

        public void AddTitleOfPage(TitleOfPage titleOfPage)
        {
            context.TitleOfPages.Add(titleOfPage);
            context.SaveChanges();
        }
    }
}
