using System;

namespace exercise_47
{
  class Program
  {
    public static void Main(string[] args)
    {

      
        // Ask for starting value
    Console.WriteLine("Where to?");
     //declare variable, assign value, read the users input and convert it to integer
      int userInputEnd = Convert.ToInt32(Console.ReadLine());
       //ask for ending value
      Console.WriteLine("Where from?");
      int userInputStart = Convert.ToInt32(Console.ReadLine());
      //set the userInputStart as a starting value of the for loop 
      int start= userInputStart;
     //set userInputEnd as an end value for the for loop
      int end = userInputEnd;
       //create the for loop and print it out 
      for (int i = start; i <= end; i++)

           {
            //print number from start to end
            Console.WriteLine(i);
          
            }
    }
  }
}
