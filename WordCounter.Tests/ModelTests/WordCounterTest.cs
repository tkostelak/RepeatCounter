using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterApp.Models;
using System.Collections.Generic;
using System;

namespace WordCounterApp.Test
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void IsWordNumOrSym_userWordInputIsNumber_True()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      //Act
      bool result = testWordCounter.IsWordNumOrSym("Hello");
      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsWordNumOrSym_userWordInputIsNumber_False()
    {
      //Arrange
      WordCounter testWordCounter2 = new WordCounter();
      //Act
      bool result = testWordCounter2.IsWordNumOrSym("12345");
      //Assert
      Assert.AreEqual(false, result);
    }

  }
}
