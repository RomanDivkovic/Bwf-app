using Microsoft.EntityFrameworkCore;
using BettingApp.Models;

namespace BettingApp.Data
{
    public class BettingContext : DbContext
    {
        public BettingContext(DbContextOptions<BettingContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Invitation> Invitations { get; set; }
    }
}
