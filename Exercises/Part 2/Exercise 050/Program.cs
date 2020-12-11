using System;

namespace exercise_50
{
  class Program
  {
    public static void Main(string[] args)
    {
     
     // ask the user for the number of times that the phrase will be printed
     // use the while command to call the method a suitable number of times
     // Call your method here:
       Console.WriteLine("How many times?");
       //declare variable, assign value, read the users input and convert it to integer
       int userInput= Convert.ToInt32(Console.ReadLine());
       //this variable stores the times the phrase should be printed
       int numberOfTimes = 0; 
       while (numberOfTimes < userInput)
       {
            PrintPhrase();
            numberOfTimes++;
       }
    }

    // Write your method here:
    public static void PrintPhrase() 
        {
          
         
         Console.WriteLine("In a hole in the ground there lived a method");
          
         }
       
    }
  }

