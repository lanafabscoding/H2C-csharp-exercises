using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
       // ask the speed from the user
      Console.WriteLine("Give a number:");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
     //Convert string to integer type
     int year = Convert.ToInt32(userInput);
     //show the users input 
     if (year == 1984)
     {
         Console.WriteLine("Orwell");
     }

    }
  }
}
