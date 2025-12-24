using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using server.Models;

namespace server.Interfaces
{

    public interface INoteRepository
    {
        Task<Note?> GetByIdAsync(int id);
    }
}