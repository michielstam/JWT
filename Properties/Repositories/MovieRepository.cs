using Catalog.Models;

namespace Catalog.Repositories
{
    public class MovieRepository 
    {
       public static List<Movie> Movies = new()
       {
           new() {Id = 1, Title = "Demo", Description = "Demo Film", Rating = 4.2 }
       };
    }
}