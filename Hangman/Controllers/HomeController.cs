using Microsoft.AspNetCore.Mvc;
using Hangman.Models;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      Game myGame = new Game();
      return View(myGame); 
    }
  }
}