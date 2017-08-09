
using Microsoft.AspNetCore.Mvc;
using RPG.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using System.Linq;

namespace RPG.Controllers
{
    [Authorize]
    public class ItemController : Controller
    {
        private readonly RPGDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public ItemController(RPGDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View(_db.Items.ToList());
        }
    }
}
