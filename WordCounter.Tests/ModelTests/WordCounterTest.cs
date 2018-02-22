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
    public void WordCountTracker_WordInputIsSameAsSentence_Return_1()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      //Act
      int result = testWordCounter.WordCountTracker("Hello","Hello");
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void WordCountTracker_WordInputIsDifferentFromSentence_Return_0()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      //Act
      int result = testWordCounter.WordCountTracker("Hello","Goodbye");
      //Assert
      Assert.AreEqual(0, result);
    }
    [TestMethod]
    public void SentenceToUpper_WordInputAndSentenceInputHaveDifferentCapitalization_Return_Equal()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      string userWordInput = "dog";
      string userSentenceInput = "Dog";
      //Act
      string resultUserWordInput = testWordCounter.WordToUpper(userWordInput);
      string resultUserSentenceInput = testWordCounter.SentenceToUpper(userSentenceInput);
      //Assert
      Assert.AreEqual(resultUserWordInput, resultUserSentenceInput);
    }
    [TestMethod]
    public void WordCountSentence_WordInputOccursOneTimeInSentenceOfStrings_Return_1()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      string userWordInput = "dog";
      string userSentenceInput = "the dog barked";
      //Act
      int wordCountResult = testWordCounter.WordCountSentence(userWordInput, userSentenceInput);
      //Assert
      Assert.AreEqual(1, wordCountResult);
    }
    [TestMethod]
    public void WordCountSentence_WordInputOccursThreeTimesInSentenceOfStrings_Return_3()
    {
      //Arrange
      WordCounter testWordCounter = new WordCounter();
      string userWordInput = "dog";
      string userSentenceInput = "the dog barked at the other dog in the way that a dog typically would.";
      //Act
      int wordCountResult = testWordCounter.WordCountSentence(userWordInput, userSentenceInput);
      //Assert
      Assert.AreEqual(3, wordCountResult);
    }


  }
}
