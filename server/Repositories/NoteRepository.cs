using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Models;

namespace server.Repositories
{
    public class NoteRepository:INoteRepository
    {
        private readonly ApplicationDbContext _context;
        public NoteRepository(ApplicationDbContext context) => _context = context;
        public async Task<Note?> GetByIdAsync(int id)
        {
            return await _context.Notes
                        .Include(n => n.Cards)
                        .FirstOrDefaultAsync(n => n.Id == id);
        }
    }
}