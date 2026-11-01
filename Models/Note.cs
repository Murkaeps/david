using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Text;

namespace AvaloniaApplication13.Models
{
    
    public class Note
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }  = string.Empty;
        [Required]
        [MaxLength(100)]
        public string Content { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; }
        public Note(string title, string content)
        {
            Title = title;
            Content = content;
            CreateAt = DateTime.Now;
        }
    }
}
