using System;

namespace StringConcatenation
{
    class Program
    {
        static void Main()
        {
            string firstName = "Bob";
            string greeting = "Hello";

            // Combining strings using +
            Console.WriteLine(greeting + " " + firstName + "!");

            int messages = 3;

            Console.WriteLine("You have " + messages + " new messages.");
        }
    }
}