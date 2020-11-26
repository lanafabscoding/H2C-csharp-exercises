using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

         //declare variable, assign value, read the users input and convert it to integer
      int userInput = Convert.ToInt32(Console.ReadLine());
      //set the userInput as a starting value of the for loop 
      int start= userInput;
     //set 100 as an end value for the for loop
      int end = 100;
       //create the for loop and print it out 
      for (int i = start; i <= end; i++)

           {

            Console.WriteLine(i);
          
            }

    }
  }
}
