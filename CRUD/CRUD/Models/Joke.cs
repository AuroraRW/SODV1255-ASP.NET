using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Joke
    {
        public int id { get; set; }

        [Required]
        public string JokeQuestion { get; set; }
        [Required]
        public string JokeAnswer { get; set; }
    }
}
