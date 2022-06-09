using System;

namespace MoviesWeb.Models
{
    public class MovieModel
    {
        public int Id { get; set; }
        public int MoviePrice { get; set; }
        public string ReleasedDate { get; set; } = DateTime.Now.ToShortDateString();
        public string MovieName { get; set; }
        public string MovieDescription { get; set; }
        public string MovieType { get; set; }
        
    }
}
