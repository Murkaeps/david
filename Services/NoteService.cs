using AvaloniaApplication13.Models;
using AvaloniaApplication13.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication13.Services;

public class NoteService(INoteRepository repo) : INoteService

{
    public async Task AddAsync(string title, string content)
    {
        await repo.AddNoteAsync(new Note(title, content));
    }

    public async Task DeleteAsync(Note? note)
    {
        if (note == null) return;
        await repo.DeleteNoteAsync(note);
    }

    public async Task<List<Note>> GetAllAsync()
    {
        return await repo.GetNoteAsync();
    }

    public async Task<Note?> GetIdAsync(int id)
    {
        return await repo.GetNoteAsync(id);
    }
}
