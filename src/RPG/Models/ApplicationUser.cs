using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace RPG.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public ApplicationUser()
        //{
        //    this.Items = new HashSet<Item>();
        //}

        //public virtual ICollection<Item> Items { get; set; }
    }
}
