using System;

namespace exercise_22
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
       //ask third number from the user
     Console.WriteLine("Give the third number! ");
    // Declare and assign the input as string
     string userInput3 = Console.ReadLine();
     // Convert string to integer type
     int thirdNumber = Convert.ToInt32(userInput3);
     //make the calculation and print it to the user
     double answer = (firstNumber + secondNumber + thirdNumber)/3.0;
     //print the equation tot the user.
     Console.WriteLine("The average is " + answer);

    }
  }
}
