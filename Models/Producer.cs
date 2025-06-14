using System.ComponentModel.DataAnnotations;

namespace ticket.Models
{
    public class Producer
    {
        [Key] public int Id { get; set; }
        public string Bio { get; set; }
        public string ProfPicUrl { get; set; }
        public string Full_name { get; set; }
        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
