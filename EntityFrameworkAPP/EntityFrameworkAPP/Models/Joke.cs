using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkAPP.Models
{
    public class Joke
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string JokeQuestion { get; set; } = "";
        [Required]
        public string JokeAnswer { get; set; } = "";
    }
}
