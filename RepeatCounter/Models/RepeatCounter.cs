using System.Collections.Generic;
using System;

namespace RepeatCounterApp.Models
{
  public class RepeatCounter
  {
    public static int _wordInstance = 0;

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

    public int RepeatCountTracker(string userWordInput, string userSentenceInput)
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

    public int RepeatCountSentence(string userWordInput, string userSentenceInput)
    {
      string[] sentenceInputArray = userSentenceInput.Split();
      {
        foreach(string word in sentenceInputArray)
        {
          if (word == userWordInput)
          {
            _wordInstance += 1;
          }
        }
        return _wordInstance;
      }
    }
  }
}
