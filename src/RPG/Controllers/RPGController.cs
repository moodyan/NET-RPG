using Microsoft.AspNetCore.Mvc;
using RPG.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace RPG.Controllers
{
    [Authorize]
    public class RPGController : Controller
    {
        private readonly RPGDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public RPGController (UserManager<ApplicationUser> userManager, RPGDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
