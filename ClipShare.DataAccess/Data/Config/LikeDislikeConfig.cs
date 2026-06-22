using ClipShare.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipShare.DataAccess.Data.Config
{
    public class LikeDislikeConfig : IEntityTypeConfiguration<LikeDisLike>
    { 
        public void Configure(EntityTypeBuilder<LikeDisLike> builder)
        {
            builder.HasKey(x => new { x.AppUserId, x.VideoId });
            builder.HasOne(a => a.AppUser).WithMany(c => c.LikeDisLikes).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.Video).WithMany(c => c.LikeDisLikes).HasForeignKey(c => c.VideoId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
