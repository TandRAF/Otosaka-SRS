using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Dtos.CardDto
{
    public class CardReadDto
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public int DeskId { get; set; }
        
    }
}