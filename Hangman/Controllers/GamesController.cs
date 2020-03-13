using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GamesController : Controller
  {
    [HttpGet("/games")]
    public ActionResult Index() 
    { 
      List<char> allGuessedLetters = Game.GetAllGuessedLetters();

      
      return View(allGuessedLetters);
    }

    [HttpGet("/games/new")]
    public ActionResult New() 
    {
      Game.GuessMessage = "";
      return View(); 
    }

    [HttpPost("/games")]
    public ActionResult Create(char guess) 
    { 
      if (guess == default(char))
      {
        Game.GuessMessage = "No letter added. Please enter a letter!";
      }
      else if (Game.AlreadyGuessed(guess))
      {
        Game.GuessMessage = "Already guessed before! Try another Letter.";
      }
      else
      {
        if(Game.GuessLetterCorrectly(guess))
        {
          Game.CharacterMatches(guess);
          Game.GuessMessage = "Correct!";
        }
        else
        {
          Game.GuessMessage = "Incorrect!";
        }
        
      }
      Game.CheckGameOver();
      if(Game.GameOver)
      {
        if(Game.WrongGuesses >=6)
        {
          Game.GuessMessage = "Game Over! You Lost!";
        }
        else
        {
          Game.GuessMessage = "You win!";
        }
      }
      return RedirectToAction("Index");
    }
  }
}