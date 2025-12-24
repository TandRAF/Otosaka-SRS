using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Dtos.NoteDto;
using server.Interfaces;

namespace server.Controllers
{
    [Route("api/Notes")]
    [ApiController]
    public class NoteController:ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController( INoteService noteService)
        {
            _noteService = noteService;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) 
            => await _noteService.GetNoteByIdAsync(id) is NoteReadDto note ? Ok(note) : NotFound();
    }
}