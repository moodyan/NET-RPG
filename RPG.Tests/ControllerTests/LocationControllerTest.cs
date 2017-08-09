using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using RPG.Controllers;
using RPG.Models;
using Xunit;
using Microsoft.AspNetCore.Identity;

namespace RPG.Tests.ControllerTests
{
    [Collection("RPGTestCollection")]
    public class LocationControllerTest
    {
        private readonly RPGDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public LocationControllerTest(RPGDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        [Fact]
        public void Get_ViewResult_Index_Test()
        {
            //Arrange
            LocationController controller = new LocationController(_userManager, _db);
            //Act
            var result = controller.Index();
            //Assert
            Assert.IsType<ViewResult>(result);

        }

        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            LocationController controller = new LocationController(_userManager, _db);
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;
            //Act
            var result = indexView.ViewData.Model;
            //Assert
            Assert.IsType<List<Location>>(result);
        }
    }
}
