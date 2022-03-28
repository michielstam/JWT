using Catalog.Models;
using Catalog.Repositories;

namespace Catalog.Services;

public class MovieService : IMovieService
{
    public Movie Create(Movie movie)
    {
        movie.Id = MovieRepository.Movies.Count +1;
        MovieRepository.Movies.Add(movie);

        return movie;
    }

    public bool Delete(int id)
    {
        var movie = MovieRepository.Movies.FirstOrDefault(o => o.Id == id);

        if (movie is null) return false;
        MovieRepository.Movies.Remove(movie);

        return true;
    }

    public Movie Get(int id)
    {
        var movie = MovieRepository.Movies.FirstOrDefault(o => o.Id == id);
        if (movie is null) return null;

        return movie;
    }

    public List<Movie> List()
    {
        return MovieRepository.Movies;
    }

    public Movie Update(Movie newMovie)
    {
        var oldMovie = MovieRepository.Movies.FirstOrDefault(o => o.Id == newMovie.Id);
        if (oldMovie is null) return null;

        oldMovie.Title = newMovie.Title;
        oldMovie.Description = newMovie.Description;
        oldMovie.Rating = newMovie.Rating;

        return newMovie;
    }
}