using ClipShare.Core.Entites;
using ClipShare.DataAccess.Data.Config;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ClipShare.DataAccess.Data
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
            
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Channel> Channel { get; set; }
        public DbSet<Video> Video { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //shorter way to apply all configurations from the assembly
            //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //longer way to apply configurations one by one
            builder.ApplyConfiguration(new CommentConfig());
            builder.ApplyConfiguration(new SubscribeConfig());
            builder.ApplyConfiguration(new LikeDislikeConfig());
        }   
    }
}
