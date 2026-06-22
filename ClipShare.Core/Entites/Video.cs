using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClipShare.Core.Entites
{
    public class Video : BaseEntity
    {
        [Required]
        public string ThubnailUrl { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string ContentType { get; set; }
        [Required]
        public byte[] Contents { get; set; }

        public int CategoryId { get; set; }
        public int ChannelId { get; set; }

        //navigation
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [ForeignKey("ChannelId")]
        public Channel Channel { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<LikeDisLike> LikeDisLikes { get; set; }
    }
}
