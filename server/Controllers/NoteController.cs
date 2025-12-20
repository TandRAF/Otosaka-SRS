using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;

namespace server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController:ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public NoteController( ApplicationDbContext context )
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var notes = await _context.Notes.ToListAsync();
            return Ok(notes);
        }
    }
}