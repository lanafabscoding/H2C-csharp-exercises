using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
       // while loop with 0 being the number that ends the program
      while (true)
      {
       //Ask number from user
       Console.WriteLine("Give a number:");
       //read the input 
        int number = Convert.ToInt32(Console.ReadLine());
       //if number is 0 quit the program
        if (number == 0)
        {
         break;
        }
        //if number is less than 0 give error
        else if (number < 0)   
        {
           Console.WriteLine("That is negative");  
           continue;  
        }
       else 
       {
        Console.WriteLine(number*number);
       }
      }
    }
  }
}
