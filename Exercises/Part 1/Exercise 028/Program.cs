using System;

namespace exercise_28
{
  class Program
  {
    public static void Main(string[] args)
    {
       // ask a number from the user
      Console.WriteLine("How old are you?");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
     //Convert string to integer type
     int age = Convert.ToInt32(userInput);
     //show the users input 
     if (age <= 17)
     {
         Console.WriteLine("You are under age!");
     }
     else
     {
         Console.WriteLine("You are and adult!");
     }
    


    }
  }
}
