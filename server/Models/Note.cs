using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int DeskId { get; set; }
        public string NoteType { get; set; } = string.Empty;
        public string ContentJSON { get; set; } = string.Empty;
        public ICollection<Card> Cards { get; set; } = [];
    }
}