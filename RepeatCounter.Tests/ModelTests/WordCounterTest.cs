using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounterApp.Models;
using System.Collections.Generic;
using System;

namespace RepeatCounterApp.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void IsWordNumOrSym_userWordInputIsNumber_True()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      //Act
      bool result = RepeatCounter.IsWordNumOrSym("Hello");
      //Assert
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void IsWordNumOrSym_userWordInputIsNumber_False()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      //Act
      bool result = RepeatCounter.IsWordNumOrSym("12345");
      //Assert
      Assert.AreEqual(false, result);
    }

    [TestMethod]
    public void RepeatCountTracker_WordInputIsSameAsSentence_Return_1()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      //Act
      int result = RepeatCounter.RepeatCountTracker("Hello","Hello");
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void RepeatCountTracker_WordInputIsDifferentFromSentence_Return_0()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      //Act
      int result = RepeatCounter.RepeatCountTracker("Hello","Goodbye");
      //Assert
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void SentenceToUpper_WordInputAndSentenceInputHaveDifferentCapitalization_Return_Equal()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWordInput = "dog";
      string userSentenceInput = "Dog";
      //Act
      string resultUserWordInput = RepeatCounter.WordToUpper(userWordInput);
      string resultUserSentenceInput = RepeatCounter.SentenceToUpper(userSentenceInput);
      //Assert
      Assert.AreEqual(resultUserWordInput, resultUserSentenceInput);
    }
    [TestMethod]
    public void RepeatCountSentence_WordInputOccursOneTimeInSentenceOfStrings_Return_1()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWordInput = "dog";
      string userSentenceInput = "the dog barked";
      //Act
      int repeatCountResult = RepeatCounter.RepeatCountSentence(userWordInput, userSentenceInput);
      //Assert
      Assert.AreEqual(1, repeatCountResult);
    }
    [TestMethod]
    public void RepeatCountSentence_WordInputOccursThreeTimesInSentenceOfStrings_Return_3()
    {
      //Arrange
      RepeatCounter testRepeatCounter = new RepeatCounter();
      string userWordInput = "dog";
      string userSentenceInput = "dog dog dog.";
      //Act
      int repeatCountResult = RepeatCounter.RepeatCountSentence(userWordInput, userSentenceInput);
      //Assert
      Assert.AreEqual(3, repeatCountResult);
    }
  }
}
