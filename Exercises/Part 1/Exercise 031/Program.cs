using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask a number from the user
      Console.WriteLine("Give a number:");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
      //Convert string to integer type
      int number = Convert.ToInt32(userInput);
      //built the if else clause to check if which answer to give 
     if (number % 2 == 0) 
     {
         Console.WriteLine("It is even."); 
     }
     else 
     {
        Console.WriteLine("It is odd.");
     }
    }
  }
}
