using System;

namespace Classes_Olivia_Babcock
{
    class Program
    {
        static void Main(string[] args)
        {   // Creates a new greeting
            Greetings greetings = new Greetings();
           // Prints "Hello Traveler, welcome!" to the console
            greetings.Welcome();

            // Asks user for their name
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            
            // Defines the user's name
            greetings.Hello(userName);
        }
    }
}
