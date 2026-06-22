using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class AppUser : IdentityUser<int>
    {
        [Required]
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        //Navigation
        public Channel Channel { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Subscribe> Subscriptions { get; set; }
        public ICollection<LikeDisLike> LikeDisLikes { get; set; }
    }
}
