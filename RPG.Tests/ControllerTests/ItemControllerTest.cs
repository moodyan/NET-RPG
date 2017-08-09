//using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc;
//using RPG.Controllers;
//using RPG.Models;
//using Xunit;
//using Microsoft.AspNetCore.Identity;

//namespace RPG.Tests.ControllerTests
//{
//    public class ItemControllerTest
//    {


//        [Fact]
//        public void Get_ViewResult_Index_Test()
//        {
//            //Arrange
//            ItemController controller = new ItemController();
//            //Act
//            var result = controller.Index();
//            //Assert
//            Assert.IsType<ViewResult>(result);

//        }

//        [Fact]
//        public void Get_ModelList_Index_Test()
//        {
//            //Arrange
//            ItemController controller = new ItemController();
//            IActionResult actionResult = controller.Index();
//            ViewResult indexView = controller.Index() as ViewResult;
//            //Act
//            var result = indexView.ViewData.Model;
//            //Assert
//            Assert.IsType<List<Item>>(result);
//        }
//    }
//}
