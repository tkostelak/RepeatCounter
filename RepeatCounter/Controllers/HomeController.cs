using Microsoft.AspNetCore.Mvc;
using RepeatCounterApp.Models;
using System.Collections.Generic;
using System;

namespace RepeatCounterApp.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpGet("/form")]
      public ActionResult Form()
      {
        return View();
      }
      [HttpPost("/")]
      public ActionResult Display()
      {
        RepeatCounter.ResetRepeatScore();
        RepeatCounter newRepeatCounter = new RepeatCounter();
        string userWordInput = RepeatCounter.WordToUpper(Request.Form["wordInput"]);
        string userSentenceInput =  RepeatCounter.SentenceToUpper(Request.Form["sentenceInput"]);
        RepeatCounter.IsWordNumOrSym(userWordInput);
        RepeatCounter.SetUserWordResults(userWordInput);
        string userWordResults = RepeatCounter.GetUserWordResults();
        int repeatResult =

        RepeatCounter.RepeatCountSentence(userWordInput, userSentenceInput);
        return View("Index", newRepeatCounter);
      }
    }
}
