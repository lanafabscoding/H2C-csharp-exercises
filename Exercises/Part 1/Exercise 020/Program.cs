using System;

namespace exercise_20
{
  class Program
  {
    public static void Main(string[] args)
    {

     //ask a number from the user
     Console.WriteLine("Give the first number! ");
     // Declare and assign the input as string
     string userInput = Console.ReadLine();
     // Convert string to integer type
     int firstNumber = Convert.ToInt32(userInput);
     //ask for the second number
      Console.WriteLine("Give the second number! ");
      // Declare and assign the input as string
     string userInput2 = Console.ReadLine();
     // Convert string to integer type
     int secondNumber = Convert.ToInt32(userInput2);

     //make the calculation and print it to the user
     int answer = firstNumber * secondNumber;
     //print the equation tot the user.
     Console.WriteLine(firstNumber + " * " +secondNumber + " = " + answer);

    }
  }
}
