using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Dtos.CardDto;
using server.Models;

namespace server.Dtos.NoteDto
{
    public class NoteReadDto
    {
        public string NoteType { get; set; } = string.Empty;
        public string ContentJSON { get; set; } = string.Empty;
        public ICollection<CardReadDto> CardReadDtos { get; set; }  = [];
    }
}