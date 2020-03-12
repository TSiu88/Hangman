using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    public string Property { get; set; }
    private static List<Game> _instances = new List<Game>() {};
    public int Id { get; }
    public Game(string property)
    {
      Property = property;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Game> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Game Find(int searchId)
    {
      return _instances[searchId-1];
    }
  }
}