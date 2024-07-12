namespace BettingApp.Models
{
    public class Invitation
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public string Email { get; set; }
        public bool IsAccepted { get; set; }
    }
}
