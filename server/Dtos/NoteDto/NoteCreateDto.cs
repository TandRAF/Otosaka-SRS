using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Dtos.NoteDto
{
    public class NoteCreateDto
    {
        public string NoteType { get; set; } = string.Empty;
        public string ContentJSON { get; set; } = string.Empty;
    }
}