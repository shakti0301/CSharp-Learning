using System;

namespace EscapeSequences
{
    class Program
    {
        static void Main()
        {
            // -----------------------------------------
            // Escape Sequences in C#
            // -----------------------------------------

            // \n → New line
            Console.WriteLine("Hello\nWorld!");

            // \t → Tab space
            Console.WriteLine("Hello\tWorld!");

            // \" → Display double quotes inside a string
            Console.WriteLine("He said \"C# is awesome!\"");

            // \\ → Display backslash
            Console.WriteLine("File path: c:\\source\\repos");

            // Combining multiple escape sequences
            Console.WriteLine("\nLearning\tC#\nEscape\tSequences");
        }
    }
}