using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Site.Areas.Admin.Models;


namespace Site.Controllers
{
    public class SiteController : Controller
    {
        private ITitleOfPageRepository repository;

        public SiteController(ITitleOfPageRepository repo)
        {
            repository = repo;
        }
        public IActionResult Shef(int id)
        {
            return View(repository.TitleOfPages.Where(p => p.PageNumber == id).FirstOrDefault());
        }
    }
}
