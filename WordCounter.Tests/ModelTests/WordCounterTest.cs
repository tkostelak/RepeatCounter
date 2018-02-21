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
      WordCounter testWordCounter = new WordCounter();
      //Act
      bool result = testWordCounter.IsWordNumOrSym("12345");
      //Assert
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void WordCountTracker_WordInputIsSameAsSentence_Return1()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      //Act
      int result = testWordCounter.WordCountTracker("Hello","Hello");
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordCountTracker_WordInputIsDifferentFromSentence_Return0()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      //Act
      int result = testWordCounter.WordCountTracker("Hello","Goodbye");
      //Assert
      Assert.AreEqual(0, result);
    }
  }
}
