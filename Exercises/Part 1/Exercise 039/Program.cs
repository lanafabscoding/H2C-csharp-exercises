﻿using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
     int sum = 0;
      // Repeat until the block has been exited
    while (true) 
    {

    // Ask for integers
    Console.WriteLine("Give a number:");
    // Read user input
    int number = Convert.ToInt32(Console.ReadLine());
    // If the input is 0, exit the loop
    if (number == 0) 
    {
        break;
    }
    // If the input is other than 0
    if  (number !=0)
    {
        // Count the negative numbers
        sum = sum + number;
    }

    
     
}

        // Print the sum
        Console.WriteLine("Total sum of numbers: " + sum);

    }
  }
}
