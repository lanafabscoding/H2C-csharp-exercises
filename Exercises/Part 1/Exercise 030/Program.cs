using System;

namespace exercise_30
{
  class Program
  {
    public static void Main(string[] args)
    {
      // ask a number from the user
      Console.WriteLine("Give your percent [0 -100]");
      //Deaclare and assing the input as a string
      string userInput = Console.ReadLine();
      //Convert string to integer type
      int number = Convert.ToInt32(userInput);
      
    //let us build up the conditions
    if (number < 0)
     {
           Console.WriteLine("Impossible");
     }
    else if (number < 50) 
     {
           Console.WriteLine("Fail");

    }

    else if (number <60) 
     {
           Console.WriteLine("Grade: 1");

    }

    else if (number <70) 
     {
           Console.WriteLine("Grade: 2");

    }

     else if (number <80) 
     {
           Console.WriteLine("Grade: 3");

    }

     else if (number <90) 
     {
           Console.WriteLine("Grade: 4");

    }

    
     else if (number <100) 
     {
           Console.WriteLine("Grade: 5");

    }


    else 
     {
            Console.WriteLine("Outstanding!");   
     }
   

    }
  }
}
