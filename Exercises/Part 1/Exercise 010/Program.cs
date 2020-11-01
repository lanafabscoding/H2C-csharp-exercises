using System;

namespace exercise_10
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.\n"+"Give a name for main character:");
            /*create a string for the name and assing it to a variable*/
            string nameOfCharacter = Console.ReadLine();
            // ask characters profession 
            Console.WriteLine("Give the character a profession:");
            //create a string for the profession and assign it to a variable
            string profession = Console.ReadLine();
            //create the story by contactenating the story line and the strings to their places. 
            Console.WriteLine("Here is the story:"+" Once upon a time there was a "+profession +" called "+nameOfCharacter + "."+"\n"+"On her way to work, "+nameOfCharacter +" often pondered what being "+ profession + " meant to them.\n" +
                "When you work as a " + profession + " you meet interesting people.\n" + nameOfCharacter + " enjoys their work as " + profession +", The end.");
        }
    }
}
