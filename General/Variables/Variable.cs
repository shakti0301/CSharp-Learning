using System;

namespace Variables
{
    class Variable
    {
        static void Main(String[] args)
        {
            // Declare a variable to store the user's name and initialize it with an empty string
            string name;

            // Ask the user for their name
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            //byte
            byte age = Console.ReadByte();

            //int
            int year = Console.Read();

            //float
            float height = float.Parse(Console.ReadLine()); // You can use Console.ReadLine() and then convert it to float using float.Parse() or float.TryParse()

            //double
            double weight = double.Parse(Console.ReadLine()); // Similar to float, you can use Console.ReadLine() and then convert it to double using double.Parse() or double.TryParse()

            //char
            char grade = Console.ReadKey().KeyChar; // Reads a single character from the user input

            //bool
            Console.Write("Are you a student? (true/false): ");
            bool isStudent = bool.Parse(Console.ReadLine()); // You can use Console.ReadLine() and then convert it to bool using bool.Parse() or bool.TryParse()

            //Var
            var country = "India"; // The type of the variable 'country' is inferred to be string based on the assigned value.

            //Printing the values of the variables
            // Greet the user
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("Your Age: " + age);
            Console.WriteLine("Your Year: " + year);
            Console.WriteLine("Your Height: " + height);
            Console.WriteLine("Your Weight: " + weight);
            Console.WriteLine("Your Grade: " + grade);
            Console.WriteLine("Are you a student? " + isStudent);
            Console.WriteLine("You live in: " + country);


            //Ranges of data types

            System.Console.WriteLine("{0} {1}", byte.MaxValue, byte.MinValue);
            // Output: 255 0 -- The maximum value of a byte is 255 and the minimum value is 0.

            System.Console.WriteLine("{0} {1}", int.MaxValue, int.MinValue);
            // Output: 2147483647 -2147483648 -- The maximum value of an int is 2147483647 and the minimum value is -2147483648.

            System.Console.WriteLine("{0} {1}", float.MaxValue, float.MinValue);
            // Output: 3.4028235E+38 -3.4028235E+38 -- The maximum value of a float is approximately 3.4028235E+38 and the minimum value is approximately -3.4028235E+38.

            System.Console.WriteLine("{0} {1}", double.MaxValue, double.MinValue);
            // Output: 1.7976931348623157E+308 -1.7976931348623157E+308 -- The maximum value of a double is approximately 1
            // .7976931348623157E+308 and the minimum value is approximately -1.7976931348623157E+308.

        }
    }
}