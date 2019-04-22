using System;
using System.Collections.Generic;

namespace Palindrome {

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter a word: ");
      string userInput = Console.ReadLine();
      char[] userInputArray = userInput.ToCharArray();
      Array.Reverse(userInputArray);
      string inputtedWordReverse = new string(userInputArray);
      if (userInput == inputtedWordReverse)
      {
        Console.WriteLine("This is a Palindrome.");
      } else
      {
        Console.WriteLine("This is not a Palindrome.");
      }
    }
  }
}
