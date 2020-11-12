using System;

namespace exercise_29
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask a number from the user
      Console.WriteLine("Give the first number!");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
      //Convert string to integer type
      int number = Convert.ToInt32(userInput);
      // ask another number from the user
      Console.WriteLine("Give the second number!");
      //Deaclare and assing the input as a string
      string userInput2 = Console.ReadLine();
      //Convert string to integer type
      int number2 = Convert.ToInt32(userInput2); 
    
    //let us build up the conditions
    if (number > number2)
     {
           Console.WriteLine("The larger number is " + number);
     }
    else if (number < number2) 
     {
           Console.WriteLine("The larger number is " + number2);

    }

    else 
     {
            Console.WriteLine("They are equal!");   
     }
   
   }
  }
}