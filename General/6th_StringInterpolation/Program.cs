using System;
namespace StringInterpolation
{
    class Program
    {
        static void Main()
        {
            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            // Using string interpolation
            Console.WriteLine($"Hello, {name}!");
            Console.WriteLine($"You have {messages} messages in your inbox.");
            Console.WriteLine($"Temperature: {temperature} Celsius");
        }
    }
}