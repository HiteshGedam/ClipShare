using System;
using System.Collections.Generic;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class Subscribe
    {
        //PK (AppUserID,ChannelId)
        //FK AppUserID
        //FK ChannelId

        public int AppUserId { get; set; }
        public int ChannelId { get; set; }

        //navigation
        public AppUser AppUser { get; set; }
        public Channel Channel { get; set; }
    }
}
