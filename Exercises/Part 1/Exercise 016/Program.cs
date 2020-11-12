using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {
    //ask number of days from the user
     Console.WriteLine("How many days? ");
     // Declare and assign the input as string
     string userInput = Console.ReadLine();
     // Convert string to integer type
     int intValue = Convert.ToInt32(userInput);
     //make the calculation and print it to the user
     int daysToSeconds = intValue*24*60*60;
     Console.WriteLine(daysToSeconds);
     
     

    }
  }
}
