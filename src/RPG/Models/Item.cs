using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Table("Items")]
    public class Item
    {
        public Item()
        {
            this.ApplicationUsers = new HashSet<ApplicationUser>();
        }
        
        [Key]
        public int ItemId { get; set; }
        public string Name { get; set; }
        public int LocationId { get; set; }
        public virtual Location ItemLocation { get; set; }
        public virtual ICollection<ApplicationUser> ApplicationUsers { get; set; }
    }
}
