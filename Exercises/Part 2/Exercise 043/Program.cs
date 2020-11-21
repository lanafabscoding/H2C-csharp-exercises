using System;

namespace exercise_43
{
  class Program
  {
    public static void Main(string[] args)
    {
       //declare variables, assign values, read the users input and convert to integer
      int userInput = Convert.ToInt32(Console.ReadLine());
      //if the number is less than 0, print multiplied by 1
      if (userInput < 0)
      {
          Console.WriteLine(userInput*-1);
      }
      else 
      {
          Console.WriteLine(userInput); 
      }
     
    }
  }
}
