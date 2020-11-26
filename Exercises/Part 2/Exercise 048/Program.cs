using System;

namespace exercise_48
{
  class Program
  {
    public static void Main(string[] args)
    {

      //Ask for numbers from the user
        Console.WriteLine("Give numbers:");
     
     double sum = 0; 
     double numbers = 0;
     double average=0;
     int even= 0;
     int odd = 0;
      while (true)
      {
        
       //declare variable, assign value, read the users input and convert it to integer
       int userInput= Convert.ToInt32(Console.ReadLine());
       //if userInput is equal to -1, break the loop and jump to Thx! Bye!
       if (userInput == -1) 
       {
               break;
               
      }
       //if userinput is else than -1 keep going
       if (userInput != -1) 
       {
           //increase the value of userInput each time of loop and add the userinput to the sum
           sum += userInput;
           userInput++;
           //count the number of given numbers
           numbers+=1;
           //count the average of given numbers
           average = sum/numbers;
         
      }
       
       if (userInput % 2 == 0)
   
       {
         even = even +1;
       }

        if (userInput % 2 != 0)
   
       {
         odd = odd +1;
       }
      
      }
      Console.WriteLine("Thx! Bye!");
      Console.WriteLine("Sum: " + sum);
      Console.WriteLine("Numbers: " + numbers);
      Console.WriteLine("Average: " + average);
      Console.WriteLine("Even: " + even);
      Console.WriteLine("Odd: " + odd);
    }
  }
}
