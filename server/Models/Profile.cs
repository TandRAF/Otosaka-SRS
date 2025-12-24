using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace server.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = new User();
        public string Bio { get; set; } = string.Empty;
        public string Scope { get; set; } = string.Empty;
    }
}