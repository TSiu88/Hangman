using System;
using System.Collections.Generic;
using System.Linq;

namespace Hangman.Models
{
  public class Game
  {
    public static string WordToGuess { get; set; }
    public static char[] CharactersToGuess;
    private static List<string> _wordList = new List<string> {"test", "guess", "words"};
  
    private static List<char> _lettersGuessed = new List<char>() {}; 
    public static int WrongGuesses { get; set; }
    public static int RightGuesses { get; set; }
    private static List<string> _visibleLetters = new List<string>() {};
    public static string GuessMessage { get; set; }
    public static bool GameOver { get; set; }

    public Game()
    {
      ClearAllGuesses();
      _visibleLetters = new List<string>() {};
      WordToGuess = RandomWordGenerator();
      CharactersToGuess = WordToGuess.ToCharArray();
      AddBlanks();
      GuessMessage = "";
      WrongGuesses = 0;
      RightGuesses = 0;
      GameOver = false;
    }

    private string RandomWordGenerator()
    {
      Random rand = new Random();
      int _wordListLength = _wordList.Count;
      int randomNumber = rand.Next(_wordListLength);
      return _wordList[randomNumber];
    }

    private void AddBlanks()
    {
      for(int i = 0; i<CharactersToGuess.Length; i++)
      {
        _visibleLetters.Add("_");
      }
    }

    public static List<string> GetAllVisibleLetters()
    {
      return _visibleLetters;
    }

    public static string VisibleLettersToString()
    {
      string visibleString = "";
      foreach(String letter in _visibleLetters)
      {
        visibleString += letter + " ";
      }
      return visibleString;
    }
    
    public static int GetWrongGuessesRemaining()
    {
      if(WrongGuesses <= 6)
      {
        return 6-WrongGuesses;
      }
      return 6;
    }

    public static string CurrentImageLink()
    {
      if(WrongGuesses <= 6)
      {
        return "Hangman" + WrongGuesses + ".png";
      }
      return "Hangman6.png";
    }

    public static List<char> GetAllGuessedLetters()
    {
      return _lettersGuessed;
    }

    public static void ClearAllGuesses()
    {
      _lettersGuessed.Clear();
    }

    public static bool AlreadyGuessed(char letter)
    {
      if (_lettersGuessed == null)
      {
        _lettersGuessed.Add(letter);
        return false;
      }
      else if (_lettersGuessed.Contains(letter))
      {
        return true;
      }
      else
      {
        _lettersGuessed.Add(letter);
        return false;
      }
    }

    public static bool GuessLetterCorrectly(char letter)
    {
      if(CharactersToGuess.Contains(letter) == true)
      {
        RightGuesses++;
        return true;
      }
      else
      {
        WrongGuesses++;
        return false;
      }
    }

    public static void CharacterMatches(char letter)
    {
      for(int i=0; i<CharactersToGuess.Length; i++)
      {
        if(letter == CharactersToGuess[i])
        {
          _visibleLetters[i] = letter.ToString();
        }
      }
    }
    
    public static void CheckGameOver()
    {
      if(WrongGuesses >= 6 || RightGuesses == (GetAllVisibleLetters().Count-1))
      {
        GameOver = true;
      }
    }
  }
}