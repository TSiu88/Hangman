using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/Games")]
    public ActionResult Index() 
    { 
      List<Game> allGames = Game.GetAll();
      return View(allGames);
    }

    [HttpGet("/games/new")]
    public ActionResult New() { return View(); }

    [HttpPost("/games")]
    public ActionResult Create(char guess) 
    { 
      
      return RedirectToAction("Index"); 
    }
  }
}