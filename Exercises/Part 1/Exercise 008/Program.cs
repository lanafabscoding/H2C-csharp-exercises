using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            // create a program that asks user for thei name and greets them. 
            //let us create the first the line of code that asks for the users name
            Console.WriteLine("What is your name?");
            //create a string variable and get users input.
            string userInput = Console.ReadLine();
            //greet the user 
            Console.WriteLine("Hello " + userInput + "!");

        }
    }
}
