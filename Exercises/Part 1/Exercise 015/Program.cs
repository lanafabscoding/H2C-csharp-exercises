using System;

namespace exercise_15
{
  class Program
  {
    public static void Main(string[] args)
    {

      //ask a string from the user
       Console.Write("Give a string: ");
      //set the users input into a string variable
       string userInput = Console.ReadLine();
      
      
      //ask an integer from the user
      Console.Write("Give an integer: ");
     // Declare and assign the input as string
     string userInput2 = Console.ReadLine();
     // Convert string to integer type
     int intValue = Convert.ToInt32(userInput2);
     
     //ask a double from the user
      Console.Write("Give an double: ");
      string userInput3 = Console.ReadLine();
     // Convert string to double type
     double doubleValue = Convert.ToDouble(userInput3);
     
     //ask a boolean from the user
      Console.Write("Give a boolean: ");
     string userInput4 = Console.ReadLine();
      string truth = "True";
      bool booleanValue = System.Convert.ToBoolean(truth);

      Console.WriteLine("Your string: " + userInput +"\n" + "Your integer: " + intValue +"\n" + "Your double: " + doubleValue + "\n" + "Your boolean: " + booleanValue);

    }
  }
}
