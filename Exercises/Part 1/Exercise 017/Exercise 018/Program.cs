using System;

namespace exercise_18
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
      
     //ask for the third number
      Console.WriteLine("Give the third number! ");
      // Declare and assign the input as string
     string userInput3 = Console.ReadLine();
     // Convert string to integer type
     int thirdNumber = Convert.ToInt32(userInput3);

     //make the calculation and print it to the user
     int sum = firstNumber + secondNumber + thirdNumber;
     Console.WriteLine("The sum is " + sum);

    }
  }
}
