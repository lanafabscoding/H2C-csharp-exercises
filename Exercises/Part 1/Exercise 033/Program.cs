using System;

namespace exercise_33
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask a string from the user
      Console.WriteLine("Give the first string:");
     //declare and assign the input as a string 
     string userInput = Console.ReadLine();
    //ask for the second string 
     Console.WriteLine("Give the second string:");
    //declare and assign the second input to a string
    string userInput2 = Console.ReadLine();

     //let's create the if else clause
     if (userInput.Equals(userInput2))
     {
        Console.WriteLine("Echo!");
     }
     else 
     {
        Console.WriteLine("Nope!");
    }

    }
  }
}
