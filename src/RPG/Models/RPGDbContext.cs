using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace RPG.Models
{
    public class RPGDbContext : IdentityDbContext<ApplicationUser>
    {
        public RPGDbContext() { }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<UserItem> UserItems { get; set; }
        public RPGDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<UserItem>()
                .HasKey(ui => new { ui.ApplicationUserId, ui.ItemId });

            builder.Entity<UserItem>()
                .HasOne(ui => ui.ApplicationUser)
                .WithMany(u => u.UserItems)
                .HasForeignKey(ui => ui.ApplicationUserId);

            builder.Entity<UserItem>()
                .HasOne(ui => ui.Item)
                .WithMany(u => u.UserItems)
                .HasForeignKey(ui => ui.ItemId);
            base.OnModelCreating(builder);

        }
        
    }
}
