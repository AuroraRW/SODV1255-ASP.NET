using Microsoft.AspNetCore.Mvc;

namespace RazorViewApp.Controllers
{
    public class ProductController : Controller
    {
        [Route("products/all")]
        public IActionResult All()
        {
            //first looking for Views/Products/All.cshtml
            //then looking for  Views/Shared/All.cshtml
            return View();
        }
    }
}
