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
    public ActionResult New() { return View(); }

    [HttpPost("/games")]
    public ActionResult Create(char guess) 
    { 
      Dictionary<string, int> dict = new Dictionary<string, int>();
      
  //     for(int i = 0; i < Game.WordToGuess.Length; i++)
  //     {
  //     if(Game.AlreadyGuessed(guess) == false)
  //     {
  //       // dict.Add("gameOver", "true");
  //       Game.WrongGuesses ++;
  //     }
  //     else if(Game.WordToGuess[i] == guess)
  //     {
  //       Game.Rightguesses++;
  //     }
  //     else if(Game.WordToGuess[i] == guess)
  //     {
  //       Game.WrongGuesses ++;
  //       Game.MatchedChar;
  //     }
  //     }
  //     dict.Add("wrongguess", Game.WrongGuesses);
  //     dict.Add("Rightguesses", Game.Rightguesses);

  //     if(Game.WrongGuesses >= 6)
  //     {
  //       Game.ClearAllGuesses();
  //       dict("gameover", "true");
  //     }
  //     else if(Game.WordToGuess.Length == Game.Rightguesses)
  //     {
  //       dict("gameover", "false");
  //     }

  // trying to figure out...!
      // else if(Game.GuessLetterCorrectly(guess) == false)
      // {
      //   Game.MatchCharValidator(guess);
      //   wrongguess ++;
      // } 
      // else if(Game.GuessLetterCorrectly(guess) == true)
      // {
      //   Game.MatchCharValidator(guess);
      //   rightguess ++;
      // }

      

      return RedirectToAction("Index", dict); 
    }
  }
}