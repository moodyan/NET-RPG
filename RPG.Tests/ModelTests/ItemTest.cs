using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RPG.Models;
using Xunit;

namespace RPG.Tests
{
    [Collection("RPGTestCollection")]
    public class ItemTest
    {
        [Fact]
        public void GetNameTest()
        {
            //Arrange
            var item = new Item();
            item.Name = "candlestick";
            //Act
            var result = item.Name;
            //Assert
            Assert.Equal("candlestick", result);
        }
    }
}
