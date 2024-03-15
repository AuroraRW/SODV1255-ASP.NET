using Microsoft.AspNetCore.Mvc;
using RazorViewApp.Models;

namespace RazorViewApp.Controllers
{
    public class HomeController : Controller
    {
        [Route("Home")]
        public IActionResult Index()
        {
            // Views folder/controller name/action method name.cshtml
            //return View();
            //return new ViewResult() { ViewName = "abc" };


            ViewData["title"] = "Index";
            return View("abc");
        }
        [Route("Data")]
        public IActionResult Data()
        {
            //ViewData["appTitle"] = "Data page";
            ViewBag.appTitle = "Data page";
            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
                new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
                new Person() { Name = "Susan", DateOfBirth = DateTime.Parse("2008-07-12"), PersonGender = Gender.Other}
             };

            //ViewData["people"] = people;
            //ViewBag.people = people;


            // Data2 is for Layout view
            return View("Data2",people);
        }

        [Route("Details/{name?}")]
        public IActionResult Details(string? name)
        {
            if (name == null)
                return Content("Person name can't be null");

            List<Person> people = new List<Person>()
            {
                new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male},
                new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female},
                new Person() { Name = "Susan", DateOfBirth = null, PersonGender = Gender.Other}
            };
            Person? matchingPerson = people.Where(temp => temp.Name == name).FirstOrDefault();
            return View(matchingPerson);
        }
        [Route("person-with-product")]
        public IActionResult PersonWithProduct()
        {
            Person person = new Person() { Name = "Sara", PersonGender = Gender.Female, DateOfBirth = Convert.ToDateTime("2004-07-01") };

            Product product = new Product() { ProductId = 1, ProductName = "Air Conditioner" };

            PersonAndProductModel PersonAndProduct = new PersonAndProductModel() { PersonData = person, ProductData = product };

            return View(PersonAndProduct);
        }
    }
}
