using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Site.Models;

namespace Site.Controllers
{
    public class TitleOfPageController : Controller
    {
        private ITitleOfPageRepository repository;
        public TitleOfPageController(ITitleOfPageRepository repo)
        {
            repository = repo;
        }

        public IActionResult List(uint id) => View(repository.TitleOfPages.Where(x => x.NumberOfPage == id));
    }
}
