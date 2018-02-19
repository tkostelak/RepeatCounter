using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterProject;
using WordCounterProject.Models;
using System.Collections.Generic;
using System.Linq;

namespace WordCounterProject.Test
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void ToListWord_UserSubmitsWord_ReturnsList()
    {
      WordCounter newWordCounter = new WordCounter();
      newWordCounter.SetSentence("hello");

      List<string> sentenceList = new list<string> {"hello friend"};

      CollectionAssert.AreEqual(wordList, newWordCounter.SentenceToList());
    }



    }
  }
