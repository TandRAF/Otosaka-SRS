using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Dtos.CardDto;

namespace server.Dtos.DeskDto
{
    public class DeskReadDto
    {
        public int Id;
        public string Title { get; set; } = string.Empty;
        public ICollection<CardReadDto> Cards { get; set; } = [];
        public ICollection<DeskReadDto> SubDesks { get; set; } = [];
    }
}