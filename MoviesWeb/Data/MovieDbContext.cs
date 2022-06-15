using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesWeb.Models;

namespace MoviesWeb.Data
{
    public class MovieDbContext : DbContext
    {
        //adding dbcontext using entityframework
        //connected sql server
        public DbSet<MovieModel> Order { get; set; }
        public DbSet<TopMovies> TopMovies { get; set; }
        public MovieDbContext(DbContextOptions<MovieDbContext>options) : base(options)
        {

        }
    }
}
