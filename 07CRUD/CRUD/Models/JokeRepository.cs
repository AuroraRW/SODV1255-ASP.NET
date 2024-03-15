namespace CRUD.Models
{
    public class JokeRepository
    {
        private static List<Joke> _jokeList = new List<Joke>()
        {
            new Joke{id = 1, JokeQuestion = "What has many rings but no fingers?", JokeAnswer = "A telephone." },
            new Joke{id = 2, JokeQuestion = "What has hands and a face, but can’t hold anything or smile?", JokeAnswer = "A clock." },
            new Joke{id = 3, JokeQuestion = "What is yours but mostly used by others?", JokeAnswer = "Your name." }
        };

        public static List<Joke> GetJokeList() { return _jokeList; }

        public static Joke? GetJokeById(int jokeId)
        {
            var joke = _jokeList.FirstOrDefault(j => j.id == jokeId);
            if (joke != null)
            {
                //return new Joke
                //{
                //    id = joke.id,
                //    JokeQuestion = joke.JokeQuestion,
                //    JokeAnswer = joke.JokeAnswer
                //};
                return joke;
            }

            return null;
        }

        public static void UpdateJoke(int jokeId, Joke joke)
        {
            if (jokeId != joke.id) return;
            var jokeToUpdate = _jokeList.FirstOrDefault(j => j.id == jokeId);
            if (jokeToUpdate != null)
            {
                jokeToUpdate.JokeQuestion = joke.JokeQuestion;
                jokeToUpdate.JokeAnswer = joke.JokeAnswer;
            }
        }
        public static void AddJoke(Joke joke)
        {
            var maxId = _jokeList.Count;
            joke.id = maxId + 1;
            _jokeList.Add(joke);
        }

        public static void DeleteJoke(int jokeId)
        {
            var joke = _jokeList.FirstOrDefault(j => j.id == jokeId);
            if (joke != null)
            {
                _jokeList.Remove(joke);
            }
        }
    }
}
