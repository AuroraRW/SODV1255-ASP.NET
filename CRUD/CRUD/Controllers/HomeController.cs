using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
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
