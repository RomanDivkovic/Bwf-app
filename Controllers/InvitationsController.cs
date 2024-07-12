using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BettingApp.Data;
using BettingApp.Models;
using System.Threading.Tasks;

namespace BettingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvitationsController : ControllerBase
    {
        private readonly BettingContext _context;

        public InvitationsController(BettingContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Invitation>> SendInvitation(Invitation invitation)
        {
            _context.Invitations.Add(invitation);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInvitation), new { id = invitation.Id }, invitation);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Invitation>> GetInvitation(int id)
        {
            var invitation = await _context.Invitations.FindAsync(id);
            if (invitation == null)
            {
                return NotFound();
            }

            return invitation;
        }
    }
}
