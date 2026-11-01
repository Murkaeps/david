using Microsoft.EntityFrameworkCore;
using System;
using AvaloniaApplication13.Models;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AvaloniaApplication13
{
    public class AppDbContext : DbContext
    {
        public DbSet<Note> Notes => Set<Note>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var appdata = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var folder = Path.Combine(appdata, "NotesApp");
            Directory.CreateDirectory(folder);
            var path = Path.Combine(folder, "app.db");
            optionsBuilder.UseSqlite($"Data Source={path}");
        }
    }
}
