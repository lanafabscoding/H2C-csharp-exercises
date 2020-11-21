using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

         //declare variables, assign values, read the users input and convert to integer
      int firstNumber = Convert.ToInt32(Console.ReadLine());
        //declare variables, assign values, read the users input and convert to integer
      int secondNumber = Convert.ToInt32(Console.ReadLine());
      //if the firstNumber is greater than secondNumber, print it
      if (firstNumber > secondNumber)
      {
          Console.WriteLine(firstNumber + " is greater than " + secondNumber + ".");
      }
      //if the firstNumber is less than SeconNumber, print it
      else if (firstNumber < secondNumber)

      {
          Console.WriteLine(firstNumber + " is less than " + secondNumber+ "."); 
      }
      //any other case print: numbers are equal
      else 
      {
       Console.WriteLine(firstNumber+ " is equal to " + secondNumber + ".");
      }

    }
  }
}
