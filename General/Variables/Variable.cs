using System;

namespace Variables
{
    class Program
    {
        static void Main()
        {
            // Declare a variable to store the user's name and initialize it with an empty string
            string name;

            // Ask the user for their name
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();

            // Greet the user
            Console.WriteLine("Hello, " + name + "!");

            //byte
            byte age = 25;
            Console.WriteLine("Your age is: " + age);

            //int
            int year = 2026;
            Console.WriteLine("The current year is: " + year);

            //float
            float height = 5.9f; // Note the 'f' suffix for float literals. otherwise, it would be treated as a double.
            Console.WriteLine("Your height is: " + height + " feet");

            //double
            double weight = 64.9; // No suffix needed for double literals.
            Console.WriteLine("Your weight is: " + weight + " KG");

            //char
            char grade = 'A';
            Console.WriteLine("Your grade is: " + grade);

            //bool
            bool isStudent = true;
            Console.WriteLine("Are you a student? " + isStudent);

            //Var
            var country = ""; // The type of 'country' is inferred to be string
            Console.WriteLine("You live in: " + country);

        }
    }
}