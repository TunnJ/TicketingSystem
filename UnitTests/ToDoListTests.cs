using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Controllers;
using ToDoList.Models;
using Xunit;

namespace ToDoListTests
{
    public class ToDoListTests
    {
        [Fact]
        public void Index_ReturnsAView()
        {
            //Arrange
            var filter = new Filters("Jacob");
            //Act
            var result = filter.HasName;
            //Assert
            Assert.True(result);
        }
    }
}
