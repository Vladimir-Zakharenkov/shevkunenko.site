using Microsoft.AspNetCore.Mvc;
using Site.Areas.Admin.Models;
using System.Linq;

namespace Site.Areas.Admin.Controllers
{
    public class TitleOfPageController : Controller
    {
        private ITitleOfPageRepository repository;
        public TitleOfPageController(ITitleOfPageRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.TitleOfPages);

        public IActionResult List() => View(repository.TitleOfPages.OrderBy(p => p.PageNumber));

        //[HttpPost]
        //public IActionResult AddTitleOfPage(TitleOfPage titleOfPage)
        //{
        //    repository.AddTitleOfPage(titleOfPage);
        //    return RedirectToAction(nameof(Index));
        //}
    }
}
