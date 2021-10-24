using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            return View();
        }
    }
}
