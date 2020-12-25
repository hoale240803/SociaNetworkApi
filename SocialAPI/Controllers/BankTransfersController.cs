using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SocialAPI.Models;

namespace SocialAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BankTransfersController : ControllerBase
    {
        private readonly socialdbContext _context;

        public BankTransfersController(socialdbContext context)
        {
            _context = context;
        }

        // GET: api/BankTransfers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BankTransfer>>> GetBankTransfers()
        {
            return await _context.BankTransfers.ToListAsync();
        }

        // GET: api/BankTransfers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BankTransfer>> GetBankTransfer(uint id)
        {
            var bankTransfer = await _context.BankTransfers.FindAsync(id);

            if (bankTransfer == null)
            {
                return NotFound();
            }

            return bankTransfer;
        }

        // PUT: api/BankTransfers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBankTransfer(uint id, BankTransfer bankTransfer)
        {
            if (id != bankTransfer.TransferId)
            {
                return BadRequest();
            }

            _context.Entry(bankTransfer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BankTransferExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/BankTransfers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<BankTransfer>> PostBankTransfer(BankTransfer bankTransfer)
        {
            _context.BankTransfers.Add(bankTransfer);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetBankTransfer", new { id = bankTransfer.TransferId }, bankTransfer);
        }

        // DELETE: api/BankTransfers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBankTransfer(uint id)
        {
            var bankTransfer = await _context.BankTransfers.FindAsync(id);
            if (bankTransfer == null)
            {
                return NotFound();
            }

            _context.BankTransfers.Remove(bankTransfer);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BankTransferExists(uint id)
        {
            return _context.BankTransfers.Any(e => e.TransferId == id);
        }
    }
}
