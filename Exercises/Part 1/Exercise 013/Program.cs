using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
     //ask a decimal number from the user 
     Console.Write("Give a decimal number, please ");
     //Declare and assign the input as string
     string userInput = Console.ReadLine();
     // Convert string to double type
     double doubleValue = Convert.ToDouble(userInput);
     //Show the result to user
     Console.WriteLine("You gave " + doubleValue);
     

    }
  }
}
