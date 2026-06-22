using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class Comment
    {
        //PK (AppUserID,VideoId)
        //FK AppUserID
        //FK VideoId

        public int AppUserId { get; set; }
        public int VideoId { get; set; }

        [Required]
        public string Content { get; set; }
        public DateTime PostedAt { get; set; } = DateTime.UtcNow;

        //naviagation
        public AppUser AppUser { get; set; }
        public Video Video { get; set; }

    }
}
