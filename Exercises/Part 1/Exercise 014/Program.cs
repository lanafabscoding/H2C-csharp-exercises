using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the Truth!");
      string userInput = Console.ReadLine();
      string truth = "True";
      bool booleanValue = System.Convert.ToBoolean(truth);
      Console.WriteLine(booleanValue);


  }
}
 } 