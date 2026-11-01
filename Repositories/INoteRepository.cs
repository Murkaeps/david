using AvaloniaApplication13.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication13.Repositories
{
    public interface INoteRepository
    {
        Task AddNoteAsync(Note note);
        Task DeleteNoteAsync(Note note);
        Task<List<Note>> GetNoteAsync();
        Task<Note?> GetNoteAsync(int id);
    }
}
