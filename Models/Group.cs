namespace BettingApp.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User CreatedBy { get; set; }
        public List<User> Members { get; set; }
        public List<Bet> Bets { get; set; }
    }
}
