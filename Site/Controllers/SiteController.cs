using Microsoft.AspNetCore.Mvc;
using Site.Models;
using System.Linq;

namespace Site.Controllers
{
    public class SiteController : Controller
    {
        //private ITitleOfPageRepository repository;

        //public SiteController(ITitleOfPageRepository repo)
        //{
        //    repository = repo;

        //}
        public IActionResult Shef(uint id)
        {

            return View(repository.TitleOfPages.Where(x => x.PageNumber == id).FirstOrDefault());
        }
    }
}
