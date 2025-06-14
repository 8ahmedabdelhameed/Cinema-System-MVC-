using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ticket.Data.Enums;

namespace ticket.Models
{
    public class Movies
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ImageUrl { get; set; }
        public MovieCategory MovieCategory { get; set; }
         
        public List<Actor_Movie> Actor_Movies { get; set; }
        public int Producer_id { get; set; }
        [ForeignKey("Producer_id")]
        public Cinema cinema { get; set; }
        public int Cinema_id { get; set; }
        [ForeignKey("Cinema_id")]
        public Producer producer { get; set; }


    }
}
