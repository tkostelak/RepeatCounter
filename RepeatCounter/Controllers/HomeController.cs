using Microsoft.AspNetCore.Mvc;
using RepeatCounterApp.Models;
using System.Collections.Generic;

namespace RepeatCounterApp.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return new EmptyResult();
      }
    }
}
