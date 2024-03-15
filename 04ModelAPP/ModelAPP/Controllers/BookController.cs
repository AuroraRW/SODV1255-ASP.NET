using Microsoft.AspNetCore.Mvc;
using ModelAPP.Models;
namespace ModelAPP.Controllers
{

    public class BookController : Controller
    {
        ////Author is route parameter, bookid is query string
        //[Route("/Books/{Author}")]
        //public IActionResult Book()
        //{
        //    int? bookid = Convert.ToInt32(Request.Query["bookid"]);
        //    string? author = Convert.ToString(Request.RouteValues["Author"]);
        //    return Content($"Book ID is:{bookid}\nAuthor is: {author}", "text/plain");
        //}

        //// pass the query string to the parameter of action method, case insensitive
        //[Route("/Books")]
        //public IActionResult Book(int? bookid, string? author)
        //{
        //    return Content($"Book ID is:{bookid}\nAuthor is: {author}", "text/plain");
        //}

        //// pass the route parameter to the parameter of action method, case insensitive
        //[Route("/Books/{BookId}/{Author}")]
        //public IActionResult Book(int? bookid, string? author)
        //{
        //    return Content($"Book ID is:{bookid}\nAuthor is: {author}", "text/plain");
        //}

        // if both provided, route parameter has higher priority 

        //// one from query string , one from route parameter
        //[Route("/Books/{BookId}/{Author}")]
        //public IActionResult Book([FromQuery] int? bookid, [FromRoute] string? author)
        //{
        //    return Content($"Book ID is:{bookid}\nAuthor is: {author}", "text/plain");
        //}

        ////if route parameter not provided, bookid is null
        //[Route("/Books/{BookId?}/{Author?}")]
        //public IActionResult Book([FromRoute] int? bookid, [FromQuery] string? author)
        //{
        //    if (bookid.HasValue == false)
        //    {
        //        return Content("ID is not found", "text/plain");
        //    }
        //    return Content($"Book ID is:{bookid}\nAuthor is: {author}", "text/plain");
        //}

        //// one from route parameter, one from query string, update the code in model
        //[Route("/Books/{BookId?}/{Author?}")]
        //public IActionResult Book(Book book)
        //{
        //    //if (book.BookId.HasValue == false)
        //    //{
        //    //    return Content("ID is not found", "text/plain");
        //    //}
        //    return Content($"Book ID is:{book.BookId}\nAuthor is: {book.Author}", "text/plain");
        //}

        ///////////////////////////////Form data binding////////////////////
        //[Route("/Books/{BookId?}/{Author?}")]
        //public IActionResult Book(Book book)
        //{
        //    if (book.BookId.HasValue == false)
        //    {
        //        return Content("ID is not found", "text/plain");
        //    }
        //    return Content($"Book ID is:{book.BookId}\nAuthor is: {book.Author}", "text/plain");
        //}

        ///////////////////////////////Model validation////////////////////
        //[Route("/Books/{BookId?}/{Author?}")]
        //public IActionResult Book(Book book)
        //{
        //    if (book.BookId.HasValue == false)
        //    {
        //        return Content("ID is not found", "text/plain");
        //    }

        //    //// Validate manually
        //    //if (string.IsNullOrEmpty(book.BookName))
        //    //{
        //    //    return BadRequest("BookName is required!");
        //    //}

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("BookName is required!");
        //    }
        //    return Content($"Book ID is:{book.BookId}\nAuthor is: {book.Author}", "text/plain");
        //}


        ////////////////////////////Catch error//////////////////////////
        [Route("/Books/{BookId?}/{Author?}")]
        public IActionResult Book(Book book)
        {
            if (book.BookId.HasValue == false)
            {
                return Content("ID is not found", "text/plain");
            }

            //// Validate manually
            //if (string.IsNullOrEmpty(book.BookName))
            //{
            //    return BadRequest("BookName is required!");
            //}

            if (!ModelState.IsValid)
            {
                List<string> errors = new List<string>();
                foreach (var value in ModelState.Values)
                {
                    foreach (var error in value.Errors)
                    {
                        errors.Add(error.ErrorMessage);
                    }
                }
                string errorMessages = string.Join("\n", errors);
                return BadRequest(errorMessages);
            }
            return Content($"Book ID is:{book.BookId}\nAuthor is: {book.Author}\nBookName is: {book.BookName}\nPrice is: {book.Price}\n", "text/plain");
        }
    }
}
