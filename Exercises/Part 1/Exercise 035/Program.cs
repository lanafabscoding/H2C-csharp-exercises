﻿using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
      // while loop 
      while (true)
      {
       Console.WriteLine("Give a number:");
        int answer = Convert.ToInt32(Console.ReadLine());
        if (answer == 42)
        {
         break;
        }
            
      }

    }
  }
}
