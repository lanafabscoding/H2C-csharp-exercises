using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

      //declare variable, assign value, read the users input and convert to integer
      int userInput = Convert.ToInt32(Console.ReadLine());
      int number= 0;

      //the userInput needs to be less than or equal to number. Then the number gets to be looped from 0 to the userInput. 
      while (number <= userInput)
           {

            Console.WriteLine(number);
            number++;
             //int userInput = Convert.ToInt32(Console.ReadLine());
            }
      
    }
  }
}
