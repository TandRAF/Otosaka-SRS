using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Card
    {
        public int Id { get; set; }
        public int NoteId { get; set; }
        public string Ordinal { get; set; } = string.Empty;
        public DateTime NextReviewDate { get; set; }
        public double EaseFactor { get; set; }
        public double IntervalDays { get; set; }
        public int Repetitions { get; set; }
        public int Status { get; set; }
    }
}