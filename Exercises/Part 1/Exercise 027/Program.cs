using System;

namespace exercise_27
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
     //show the users input 
     if (number > 0)
     {
         Console.WriteLine("It is positive");
     }
     else
     {
         Console.WriteLine("It is not positive");
     }
    }

    }
  }

