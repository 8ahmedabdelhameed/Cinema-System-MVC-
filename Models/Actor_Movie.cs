namespace ticket.Models
{
    public class Actor_Movie
    {
        public int MovieId { get; set; }
        public Movies movie {  get; set; }        
        public int ActorId { get; set; }
        public Actor actor { get; set; }
    }
}
