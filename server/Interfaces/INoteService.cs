using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Dtos.NoteDto;

namespace server.Interfaces
{
    public interface INoteService
    {
        Task<NoteReadDto?> GetNoteByIdAsync(int Id);
    }
}