using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace RPG.Models
{
    public class ApplicationUser : IdentityUser
     
    {
       //Create new table called Users with column for ApplicationUserID (one-one)
    }
}
