using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controllers
{
    public class StoreController : Controller
    {
        [Route("/category/books/{BookId}/{IsLogged}")]
        public IActionResult Books()
        {
            if (!Request.RouteValues.ContainsKey("BookId"))
            {
                return BadRequest("Id is not found");
            }
            int bookid = Convert.ToInt32(Request.RouteValues["BookId"]);
            if (bookid < 1 || bookid > 1000)
            {
                return NotFound("Id is not in range of 1 to 1000!");
            }
            bool isLogged = Convert.ToBoolean(Request.RouteValues["IsLogged"]);
            if (!isLogged)
            {
                //return Unauthorized("You are not logged in!");
                return StatusCode(Microsoft.AspNetCore.Http.StatusCodes.Status401Unauthorized);
            }
            return Content($"Id is: {bookid}, IsLogged is: {isLogged}", "text/plain");
            //return Content("Books", "text/plain");
        }
    }
}
