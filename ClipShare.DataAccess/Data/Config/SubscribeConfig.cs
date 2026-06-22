using ClipShare.Core.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClipShare.DataAccess.Data.Config
{
    public class SubscribeConfig : IEntityTypeConfiguration<Subscribe>
    {
        public void Configure(EntityTypeBuilder<Subscribe> builder)
        {
            builder.HasKey(x => new { x.AppUserId, x.ChannelId });
            builder.HasOne(a => a.AppUser).WithMany(c => c.Subscriptions).HasForeignKey(c => c.AppUserId).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(a => a.Channel).WithMany(c => c.Subscribers).HasForeignKey(c => c.ChannelId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
