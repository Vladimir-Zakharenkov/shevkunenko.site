using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Site.Areas.Admin.Models;


namespace Site.Controllers
{
    public class SiteController : Controller
    {
        private IRepository repository;

        public SiteController(IRepository repo)
        {
            repository = repo;

        }
        public IActionResult Shef()
        {

            return View();
        }
    }
}
