using Microsoft.AspNetCore.Mvc;
using Site.Areas.Admin.Models;

namespace Site.Areas.Admin.Controllers
{
    public class TitleOfPageController : Controller
    {
        private IRepository repository;
        public TitleOfPageController(IRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index() => View(repository.TitleOfPages);

        [HttpPost]
        public IActionResult AddTitleOfPage(TitleOfPage titleOfPage)
        {
            repository.AddTitleOfPage(titleOfPage);
            return RedirectToAction(nameof(Index));
        }
    }
}
