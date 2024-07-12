using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BettingApp.Data;
using BettingApp.Models;
using System.Threading.Tasks;

namespace BettingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BetsController : ControllerBase
    {
        private readonly BettingContext _context;

        public BetsController(BettingContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Bet>> PlaceBet(Bet bet)
        {
            _context.Bets.Add(bet);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetBet), new { id = bet.Id }, bet);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Bet>> GetBet(int id)
        {
            var bet = await _context.Bets.FindAsync(id);
            if (bet == null)
            {
                return NotFound();
            }

            return bet;
        }
    }
}
