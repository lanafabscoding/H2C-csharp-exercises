using System;

namespace exercise_12
{
  class Program
  {
    public static void Main(string[] args)
    {
     //ask a number from the user 
     Console.Write("Give a number! " +"\n");
     
     //declare and assing the users input as a string
     string userInput = Console.ReadLine();

     //convert string to integer type
     int intValue = Convert.ToInt32(userInput);
     
     //show the answer to the user
     Console.WriteLine("You gave " + intValue);


    }
  }
}
