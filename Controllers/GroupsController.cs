using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BettingApp.Data;
using BettingApp.Models;
using System.Threading.Tasks;

namespace BettingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupsController : ControllerBase
    {
        private readonly BettingContext _context;

        public GroupsController(BettingContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Group>> CreateGroup(Group group)
        {
            _context.Groups.Add(group);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetGroup), new { id = group.Id }, group);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Group>> GetGroup(int id)
        {
            var group = await _context.Groups.FindAsync(id);
            if (group == null)
            {
                return NotFound();
            }

            return group;
        }
    }
}
