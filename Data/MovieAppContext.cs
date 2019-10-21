using Microsoft.EntityFrameworkCore;
using aspnet.Models;

namespace aspnet.Data
{
  public class MovieAppContext : DbContext
  {
    public MovieAppContext (DbContextOptions<MovieAppContext> options) : base(options)
    {
    }

    public DbSet<Movie> Movie { get; set; }
  }
}
