using System;

namespace exercise_37
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
    // If the input other thab 0 
    else  
    {
        // Increase the value of countOnes by 1
        sum = sum + 1;
    }
}

// Print the sum
Console.WriteLine("Total amount of numbers: " + sum);

    }
  }
}
