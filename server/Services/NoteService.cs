using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using server.Dtos.NoteDto;
using server.Interfaces;
using server.Models;

namespace server.Services
{
    public class NoteService:INoteService
    {
        private readonly INoteRepository _noteRepo;
        private readonly IMapper _mapper;
        public NoteService(INoteRepository noteRepository, IMapper mapper)
        {
            _noteRepo = noteRepository;
            _mapper = mapper;
        }

        public async Task<NoteReadDto?> GetNoteByIdAsync(int Id)
        {
            var note = await _noteRepo.GetByIdAsync(Id);
            return _mapper.Map<NoteReadDto>(note);
        }

    }
}