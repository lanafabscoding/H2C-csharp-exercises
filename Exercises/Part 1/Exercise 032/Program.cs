using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask a string from the user
      Console.WriteLine("Speak, friend, and enter!");
     //declare and assign the input as a string 
     string userInput = Console.ReadLine();
     //let's create a if else clause
     if (userInput == "Mellon")
     {
        Console.WriteLine("Welcome, friend");
     }
     else 
     {
        Console.WriteLine("They've got a cave troll!");
    }
    }
  }
}
