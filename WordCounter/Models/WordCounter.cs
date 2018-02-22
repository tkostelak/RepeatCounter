using System.Collections.Generic;
using System;

namespace WordCounterApp.Models
{
  public class WordCounter
  {
    public bool IsWordNumOrSym(string userWordInput)
    {
      char[] wordInputArray = userWordInput.ToCharArray();
      foreach(char i in wordInputArray)
      {
        if ( i == '0' || i == '1' || i == '2' || i == '3' || i == '4' || i == '5' || i == '6' || i == '7' || i == '8' || i == '9')
        {
          return false;
        }
      }
      return true;
    }
    public int WordCountTracker(string userWordInput, string userSentenceInput)
    {
      if (userWordInput == userSentenceInput)
      {
        return 1;
      }
      else
      {
        return 0;
      }
    }
    public string SentenceToUpper(string userSentenceInput)
    {
      string sentenceUpper = userSentenceInput.ToUpper();
      return sentenceUpper;
    }

    public string WordToUpper(string userWordInput)
    {
      string wordUpper = userWordInput.ToUpper();
      return wordUpper;
    }
  }
}
