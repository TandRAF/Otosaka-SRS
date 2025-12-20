using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class Desk
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User{ get; set; } = new User();
        public string Title { get; set; } = string.Empty;
        ICollection<Card> Cards { get; set; } = [];
        ICollection<Desk> SubDesks { get; set; } = [];
    }
}