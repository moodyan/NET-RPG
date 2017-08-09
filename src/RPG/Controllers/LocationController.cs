using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RPG.Models;
using Microsoft.AspNetCore.Identity;

namespace RPG.Controllers
{
    public class LocationController : Controller
    {
        private readonly RPGDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public LocationController(UserManager<ApplicationUser> userManager, RPGDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Locations.ToList());
        }
    }
}
