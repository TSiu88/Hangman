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
  
    private static List<char> _lettersGuessed; 
    public static int WrongGuesses { get; set; }
    public static int Rightguesses { get; set; }
    public static List<int> MatchedChar = new List<int> {};
    public static List<int> UnmatchedChar = new List<int> {};
    public Game()
    {
      WordToGuess = RandomWordGenerator();
      CharactersToGuess = WordToGuess.ToCharArray();
      _lettersGuessed = new List<char>() {};
      WrongGuesses = 0;
      Rightguesses = 0;
    }

    private string RandomWordGenerator()
    {
      Random rand = new Random();
      int _wordListLength = _wordList.Count;
      int randomNumber = rand.Next(_wordListLength);
      return _wordList[randomNumber];
    }

    public static string CurrentImageLink()
    {
      return "Hangman" + WrongGuesses + ".png";
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
        return false;
      }
      else if (_lettersGuessed.Contains(letter))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    // public static bool GuessLetterCorrectly(char letter)
    // {
    //   // if (AlreadyGuessed)
    //   // {
    //   //   //Give error, ask to guess another letter
    //   // }
    //   _lettersGuessed.Add(letter);
    //   if(CharactersToGuess.Contains(letter) == true)
    //   {
    //     // RightGuesses ++;
    //     return true;
    //   }
    //   else
    //   {
    //     WrongGuesses++;
    //     return false;
    //   }
    // }

    // public static List<int> MatchChar(char letter)
    // {

    //   // for(int i = 0; i < CharacterstoGuess.Length; i ++)
    //   // {
    //   //   if(letter == CharacterstoGuess[i])
    //   //   {
    //   //     MatchedChar.Add(i);
    //   //   }
    //   // }
    //   // return MatchedChar;
    // }

    // public static void MatchCharValidator(char letter)
    // {

    //   for(int i = 0; i < CharactersToGuess.Length; i ++)
    //   {
    //     if(letter == CharactersToGuess[i])
    //     {
    //       // MatchedChar.Add(CharacterstoGuess[i]);
    //       Rightguesses ++;
    //     }
    //     else
    //     {
    //       // UnmatchedChar.Add(CharacterstoGuess[i]);
    //       WrongGuesses ++;
    //     }
    //   }
  
    // }
  }
}