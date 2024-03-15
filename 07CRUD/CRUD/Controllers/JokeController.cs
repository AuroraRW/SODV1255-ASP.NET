using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class JokeController : Controller
    {
        // Get all jokes
        [HttpGet]
        [Route("Joke")]
        public IActionResult Index()
        {
            var jokes = JokeRepository.GetJokeList();
            return View(jokes);
        }

        // Get one joke
        [HttpGet]
        [Route("Joke/Details/{id}")]
        public IActionResult Details(int id)
        {
            var joke = JokeRepository.GetJokeById(id);
            return View(joke);
        }

        // Edit one joke
        [HttpGet]
        [Route("/Joke/Edit/{id}")]
        public IActionResult Edit(int id)
        {
            var joke = JokeRepository.GetJokeById(id);
            return View(joke);
        }

        [HttpPost]
        [Route("/Joke/Edit/{id}")]
        public IActionResult Edit(Joke joke)
        {
            if (ModelState.IsValid)
            {
                JokeRepository.UpdateJoke(joke.id, joke);
                return RedirectToAction("Index");
            }
            return View(joke);

        }

        // Create a new joke
        [HttpGet]
        [Route("/Joke/Add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Joke/Add")]
        public IActionResult Add(Joke joke)
        {
            if (ModelState.IsValid)
            {
                JokeRepository.AddJoke(joke);
                return RedirectToAction("Index");
            }
            return View(joke);

        }

        // Delete a joke
        [HttpGet]
        [Route("/Joke/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            JokeRepository.DeleteJoke(id);
            return RedirectToAction("Index");
        }
    }
}
