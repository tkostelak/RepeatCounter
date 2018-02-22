using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounterApp.Controllers;
using WordCounterApp.Models;

namespace ToDoList.Tests
{
  [TestClass]
  public class HomeControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      HomeController controller = new HomeController();

      //Act
      ActionResult indexView = Controller.Index();

      //Assert
      Assert.IsInstanceOfType(result, ViewResult);
    }
  }
}
