using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // set the users input to a variable
            string userInput = Console.ReadLine();
            //print out the users input 3 times
            Console.WriteLine(userInput + "\n" + userInput + "\n" + userInput + "\n");
            
        }
    }
}
