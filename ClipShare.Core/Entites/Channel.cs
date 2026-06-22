using System;
using System.Collections.Generic;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class Channel : BaseEntity
    {
        public string Name { get; set; }
        public string About { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public int AppUserId { get; set; }

        //Navigationd
        public AppUser AppUser { get; set; }

        public ICollection<Video> Video { get; set; }
        public ICollection<Subscribe> Subscribers { get; set; }

    }
}
