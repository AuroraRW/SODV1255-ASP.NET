using Microsoft.EntityFrameworkCore;
using EntityFrameworkAPP.Models;

namespace EntityFrameworkAPP.Data
{
    public class JokeDbContext:DbContext
    {
        public JokeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Joke> Joke { get; set; }
    }
}
