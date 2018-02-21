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
    public void IsWordNumberOrSymbol_userWordInputIsNumber_True()
    {
      WordCounter testWordCounter = new WordCounter();
      Assert.AreEqual(true, testWordCounter.IsWordNumOrSym("70"));
    }
  }
}
