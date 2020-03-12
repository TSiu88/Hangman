using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    public string WordToGuess { get; set; }
    public static char[] CharactersToGuess;
    private static List<string> _wordList = new List<string> {"test", "guess", "words"};
  
    private static List<char> _lettersGuessed; 
    public int wrongGuesses { get; set; }
    public Game()
    {
      WordToGuess = RandomWordGenerator();
      CharactersToGuess = WordToGuess.ToCharArray();
      _lettersGuessed = new List<char>() {};
      wrongGuesses = 0;
    }

    private string RandomWordGenerator()
    {
      Random rand = new Random();
      int _wordListLength = _wordList.Count;
      int randomNumber = rand.Next(_wordListLength);
      return _wordList[randomNumber];
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
      if (_lettersGuessed.Contains(letter))
      {
        return true;
      }
      else
      {
        return false;
      }
    }


    public static bool GuessLetterCorrectly(char letter)
    {
      if (AlreadyGuessed)
      {
        //Give error, ask to guess another letter
      }
      else
      {
        _lettersGuessed.Add(letter);
        if(CharactersToGuess.Contains(letter))
        {
          return true;
        }
        else
        {
          wrongGuesses++;
          return false;
        }
      }
      
    }

    public static List<int> MatchChar(char letter)
    {
      List<int> matchChar = new List<int> {};
      for(int i = 0; i < CharacterstoGuess.Length; i ++)
      {
        if(letter == CharacterstoGuess[i])
        {
          matchChar.Add(i);
        }
      }
      return matchChar;
    }
  }
}