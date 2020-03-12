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
    public ActionResult Create(string param) 
    { 
      Game myGame = new Game(param);
      return RedirectToAction("Index"); 
    }

    [HttpGet("/games/{id}")]
    public ActionResult Show(int id) 
    { 
      Game foundGame = Game.Find(id);
      return View(foundGame); 
    }

    [HttpPost("/games/delete")]
    public ActionResult DeleteAll()
    {
      Game.ClearAll();
      return View();
    }
  }
}