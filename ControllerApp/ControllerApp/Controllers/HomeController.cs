using ControllerApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ControllerApp.Controllers
{
    public class HomeController: Controller
    {
        [Route("Home")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult()
            //{
            //    Content = "Hello World",
            //    ContentType = "text/plain"

            //    //Content = "<h1>Hello World</h1>",
            //    //ContentType = "text/html"
            //};
            return Content("<h1>Hello World</h1>", "text/html");
        }

        // Content result to return a JSON object
        //[Route("Employee/John")]
        //public ContentResult About()
        //{

        //    return Content("{\"name\":\"John\"}", "application/json");
        //}


        //Json result to return a JSON obj
        [Route("Employee/John")]
        public JsonResult About()
        {
            Employee emp = new Employee() { ID = 101, Name = "John", Salary = 10000, Age = 28 };
            return new JsonResult(emp);
        }
    }
}
