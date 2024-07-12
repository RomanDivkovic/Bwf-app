namespace BettingApp.Models
{
    public class Bet
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
        public string Fighter { get; set; }
        public DateTime BetDate { get; set; }
        public bool IsWinner { get; set; }
    }
}
