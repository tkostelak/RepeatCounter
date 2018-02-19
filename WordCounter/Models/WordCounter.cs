using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace WordCounterProject.Models
{
  public class WordCounter
  {
    private static string _word;
    private static string _sentence;

    public List<string> sentenceList = new List<string>();

    public List<string> SentenceToList(string sentence)
    {
      sentenceList.Add(sentence);
      return sentenceList;
    }


//Getters
    public string GetWord()
    {
      return _word;
    }

    public string GetSentence()
    {
      return _sentence;
    }

//Setters

    public void SetWord(string word)
    {
      _word = word;
    }

    public void SetSentence(string sentence)
    {
      _sentence = sentence;




    }
  }
}
