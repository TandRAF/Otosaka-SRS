using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace server.Models
{
    public class User
    {
        public int Id { get; set;}
        public ICollection<Desk> Desks { get; set; } = [];
        public Profile Profile { get; set; } = new Profile();
    }
}