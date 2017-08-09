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
        public RPGDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Location> Locations { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<ApplicationUser>()
            //    .HasMany<Item>(u => u.Items)
            //    .WithMany(i => i.ApplicationUsers)
            //    .Map(iu =>
            //    {
            //        iu.ToTable("ApplicationUserItem");
            //        iu.MapLeftKey("ApplicationUserId");
            //        iu.MapRightKey("ItemId");
            //    });
        }
        
    }
}
