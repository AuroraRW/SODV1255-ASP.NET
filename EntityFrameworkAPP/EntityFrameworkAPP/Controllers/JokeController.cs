using EntityFrameworkAPP.Data;
using EntityFrameworkAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkAPP.Controllers
{
    public class JokeController : Controller
    {
        public readonly JokeDbContext jokeDbContext;

        public JokeController(JokeDbContext jokeDbContext)
        {
            this.jokeDbContext = jokeDbContext;
        }

        // Get all jokes
        [HttpGet]
        [Route("Joke")]
        public async Task<IActionResult> Index()
        {
            var jokes = await jokeDbContext.Joke.ToListAsync();
            return View(jokes);
        }

        // Get one joke
        [HttpGet]
        [Route("Joke/Details/{id}")]
        public async Task<IActionResult> Details(int id)
        {
            var joke = await jokeDbContext.Joke.FirstOrDefaultAsync(j=>j.id==id);
            return View(joke);
        }

        // Edit one joke
        [HttpGet]
        [Route("/Joke/Edit/{id}")]
        public async Task<IActionResult> Edit(int id)
        {
            var joke = await jokeDbContext.Joke.FirstOrDefaultAsync(j => j.id == id);
            return View(joke);
        }

        [HttpPost]
        [Route("/Joke/Edit/{id}")]
        public async Task<IActionResult> Edit(Joke NewJoke)
        {
            if (ModelState.IsValid)
            {
                var joke = await jokeDbContext.Joke.FindAsync(NewJoke.id);
                if (joke != null)
                {
                    joke.JokeQuestion = NewJoke.JokeQuestion;
                    joke.JokeAnswer = NewJoke.JokeAnswer;
                    await jokeDbContext.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return View(NewJoke);

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
        public async Task<IActionResult> Add(Joke joke)
        {
            if (ModelState.IsValid)
            {
                await jokeDbContext.Joke.AddAsync(joke);
                await jokeDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(joke);

        }

        // Delete a joke
        [HttpGet]
        [Route("/Joke/Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var joke = await jokeDbContext.Joke.FindAsync(id);
            if (joke != null)
            {
                jokeDbContext.Joke.Remove(joke);
                await jokeDbContext.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
