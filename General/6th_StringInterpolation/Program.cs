using System;
namespace StringInterpolation
{
    class Program
    {
        static void Main()
        {
            // -----------------------------------------
            // String Interpolation
            // -----------------------------------------

            string name = "Bob";
            int messages = 3;
            decimal temperature = 34.4m;

            // Using interpolation
            Console.WriteLine($"Hello, {name}!");

            Console.WriteLine($"You have {messages} new messages.");

            Console.WriteLine($"The temperature is {temperature} Celsius.");

            // Multiple variables
            int version = 11;
            string updateText = "Update to Windows";

            Console.WriteLine($"{updateText} {version}!");

            // Interpolation + verbatim string
            string projectName = "FirstProject";

            Console.WriteLine($@"C:\Output\{projectName}\Data");
        }
    }
}