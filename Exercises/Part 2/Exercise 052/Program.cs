﻿using System;

namespace exercise_52
{
  class Program
  {
    public static void Main(String[] args)
    {

       //Create a method that prints the numbers from the number passed as a parameter down to one. 
      // Call your method here:
      PrintFromNumberToOne(5);
    }

    // Write your method here:

        public static void PrintFromNumberToOne(int numberOfTimes)
             {
            int i = numberOfTimes; 
            
        while (i > 0) {
             
        
      
      Console.WriteLine(i);
       i--;
      }
    }
  }
}
