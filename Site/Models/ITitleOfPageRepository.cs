using System.Linq;

namespace Site.Models
{
    public interface ITitleOfPageRepository
    {
        IQueryable<TitleOfPage> TitleOfPages { get; }
    }
}
