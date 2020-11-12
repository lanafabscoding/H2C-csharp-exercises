using System;

namespace exercise_24
{
  class Program
  {
    public static void Main(string[] args)
    {

      // ask the speed from the user
      Console.WriteLine("Your speed:");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
     //Convert string to integer type
     int speed = Convert.ToInt32(userInput);
     //show the users input 
     if (speed > 120)
     {
         Console.WriteLine("Speeding!");
     }
    }
  }
}
