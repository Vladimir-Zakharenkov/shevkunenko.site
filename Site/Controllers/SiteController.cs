using Microsoft.AspNetCore.Mvc;

namespace Site.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Shef()
        {
            return View();
        }
    }
}
