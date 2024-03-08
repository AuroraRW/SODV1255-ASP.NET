using Microsoft.AspNetCore.Mvc;

namespace EntityFrameworkAPP.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
