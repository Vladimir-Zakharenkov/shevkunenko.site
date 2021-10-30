using Microsoft.AspNetCore.Mvc;

namespace Site.Areas.Bootstrap5.Controllers
{
    public class BootstrapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
