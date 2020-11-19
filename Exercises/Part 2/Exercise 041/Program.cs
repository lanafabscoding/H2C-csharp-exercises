using System;

namespace exercise_41
{
  class Program
  {
    public static void Main(string[] args)
    {

      
      //declare variables, assign values, read the users input and convert to integer
      int userInput = Convert.ToInt32(Console.ReadLine());
      // Identifying the operation and declaring a variable for the result
      int solution = (userInput*userInput);
     // Printing the result of the operation
     Console.WriteLine(solution);
    }
  }
}
