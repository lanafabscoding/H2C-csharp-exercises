using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
      
     while (true) 
     {
      //ask if the user wants to continue
      Console.WriteLine("Do you want to continue?");
      //set the answer to a string 
      string input = Console.ReadLine();
      if (input =="no") 
       {
         break;
       }
       

     }
   
    }
  }
}
