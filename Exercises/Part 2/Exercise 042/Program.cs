using System;

namespace exercise_42
{
  class Program
  {
    public static void Main(string[] args)
    {

        //declare variables, assign values, read the users input and convert to integer
      int userInput = Convert.ToInt32(Console.ReadLine());
      int userInput2 = Convert.ToInt32(Console.ReadLine());
      // Identifying the operation and declaring a variable for the result
      double solution = Math.Sqrt(userInput+userInput2);
     // Printing the result of the operation
     Console.WriteLine(solution);
    
    }
  }
}
