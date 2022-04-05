using eTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }

        public string MovieName { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        public string ImageUrl { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public MovieCategory MovieCategory { get; set; }


    }
}
