using System.ComponentModel.DataAnnotations;

namespace ticket.Models
{
    public class Actor
    {
        [Key]
         public int Id { get; set; }
        public string Bio { get; set; }
        public string ProfPicUrl { get; set; }
        public string Full_name { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set;}
    }
}
