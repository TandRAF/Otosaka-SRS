using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace server.Models
{
    public class Desk
    {
        public int Id { get; set; }
        // Foreign Key of User
        public int UserId { get; set; }
        public User User{ get; set; } = new User();
        // Foreign Key of Parent Desk (nullable)
        public int? ParentDeskId { get; set; }
        public Desk? ParentDesk { get; set; } = null;
        // Desk Data
        public string Title { get; set; } = string.Empty;
        // Collections 
        public ICollection<Card> Cards { get; set; } = [];
        public ICollection<Desk> SubDesks { get; set; } = [];
    }
}