using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RPG.Models
{
    [Table("UserItems")]
    public class UserItem
    {
        [Key]
        public int ApplicationUserId { get; set; }
        [Key]
        public int ItemId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public Item Item { get; set; }


    }
}