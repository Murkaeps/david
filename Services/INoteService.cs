using AvaloniaApplication13.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication13.Services
{
    public interface INoteService
    {
        Task AddAsync(string title , string content);
        Task DeleteAsync(Note? note);
        Task<Note?> GetIdAsync(int id);
        Task<List<Note>> GetAllAsync();
    }
}
