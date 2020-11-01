using System;

namespace exercise_09
{
    class Program
    {
        public static void Main(string[] args)
        {
           //create a small conversation. 
           //ask question
           Console.WriteLine("Hello, how are you?");
           //create a string variable and get users input 
           string answer1 = Console.ReadLine();
            //add another question
           Console.WriteLine("That's interesting, tell me more.");
           //create a string variable and get users input 
           string answer2 = Console.ReadLine();
           //end the conversation 
           Console.WriteLine("Thank you for sharing!");
          

        }
    }
}
