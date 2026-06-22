using System;
using System.Collections.Generic;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class LikeDisLike
    {
        //PK (AppUserID,VideoId)
        //FK AppUserID
        //FK VideoId

        public int AppUserId { get; set; }
        public int VideoId { get; set; }
        public bool liked { get; set; }

        //naviagation
        public AppUser AppUser { get; set; }
        public Video Video { get; set; }
    }
}
