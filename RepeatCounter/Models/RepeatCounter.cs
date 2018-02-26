using System.Collections.Generic;
using System;

namespace RepeatCounterApp.Models
{
  public class RepeatCounter
  {
    public static string userWordResults;
    public static int repeatScore = 0;
    private static string _userWordInput;
    private static string _userSentenceInput;

//GETTERS AND SETTERS
    public static string GetUserWord()
    {
      return _userWordInput;
    }

    public static string GetUserSentenceInput()
    {
      return _userSentenceInput;
    }

    public static int GetRepeatScore()
    {
      return repeatScore;
    }

    public static void SetUserWordInput(string userWordInput)
    {
      _userWordInput = userWordInput;
    }

    public static void SetUserSentenceInput(string userSentenceInput)
    {
      _userSentenceInput = userSentenceInput;
    }


    public static void SetUserWordResults (string userWordInput)
    {
      userWordResults = userWordInput;
    }

    public static string GetUserWordResults()
    {
      return userWordResults;
    }

//METHODS
    public static void ResetRepeatScore()
    {
      repeatScore = 0;
    }

    public static bool IsWordNumOrSym(string userWordInput)
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

    public static int RepeatCountTracker(string userWordInput, string userSentenceInput)
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

    public static string SentenceToUpper(string userSentenceInput)
    {
      string sentenceUpper = userSentenceInput.ToUpper();
      return sentenceUpper;
    }

    public static string WordToUpper(string userWordInput)
    {
      string wordUpper = userWordInput.ToUpper();
      return wordUpper;
    }

    public static int RepeatCountSentence(string userWordInput, string userSentenceInput)
    {
      string[] sentenceInputArray = userSentenceInput.Split();
      {
        foreach(string word in sentenceInputArray)
        {
          if (word == userWordInput)
          {
            repeatScore += 1;
          }
        }
        return repeatScore;
      }
    }
  }
}
