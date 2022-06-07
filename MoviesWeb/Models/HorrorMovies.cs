using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWeb.Models
{
    public class HorrorMovies
    {
        public List<MovieModel> Sample()
        {
            List<MovieModel> movieModels = new List<MovieModel>();
            movieModels.Add(new MovieModel { MovieType = "Horror" });
            movieModels.Add(new MovieModel { MovieType = "Action" });
            movieModels.Add(new MovieModel { MovieType = "Thriller" });
            return movieModels;
        }
    }
}
