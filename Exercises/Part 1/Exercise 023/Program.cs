using System;

namespace exercise_23
{
  class Program
  {
    public static void Main(string[] args)
    {
     //ask number from user
     Console.WriteLine("Give the first number!");
     // Declare and assign the input as string
     string userInput = Console.ReadLine();
     // Convert string to integer type
     int firstNumber = Convert.ToInt32(userInput);
     //ask second number from user
     Console.WriteLine("Give the second number!");
     // Declare and assign the input as string
     string userInput2 = Console.ReadLine();
     // Convert string to integer type
     int secondNumber = Convert.ToInt32(userInput2);
     
     //the calculations
     int answer1 = firstNumber + secondNumber;
     int answer2 = firstNumber - secondNumber;
     int answer3 = firstNumber * secondNumber;
     double answer4 = ((double)firstNumber / secondNumber);
     //print the equations to user

     Console.WriteLine(firstNumber + " + " + secondNumber + " = " + answer1);
     Console.WriteLine(firstNumber + " - " +secondNumber + " = " + answer2);
     Console.WriteLine(firstNumber + " * " +secondNumber + " = " + answer3);
     Console.WriteLine(firstNumber + " / " +secondNumber + " = " + answer4);     

      }
  }
}
