using System;

namespace StringConcatenation
{
   using System;

    class Program
    {
        static void Main()
        {
            // -----------------------------------------
            // String Concatenation in C#
            // -----------------------------------------

            string firstName = "John";
            string lastName = "Doe";

            // Using + operator
            string fullName1 = firstName + " " + lastName;
            Console.WriteLine("Full Name (using +): " + fullName1);

            // Using String.Concat method
            string fullName2 = String.Concat(firstName, " ", lastName);
            Console.WriteLine("Full Name (using String.Concat): " + fullName2);

            // Using String Interpolation (C# 6.0+)
            string fullName3 = $"{firstName} {lastName}";
            Console.WriteLine("Full Name (using Interpolation): " + fullName3);

            // Combining multiple strings
            string city = "New York";
            string country = "USA";
            string location = $"{city}, {country}";
            Console.WriteLine("Location: " + location);
            // Concatenating numbers and strings
            int age = 30;
            string ageInfo = "Age: " + age;
            Console.WriteLine(ageInfo);
            // Concatenating with method calls
            string upperName = firstName.ToUpper() + " " + lastName.ToUpper();
            Console.WriteLine("Uppercase Name: " + upperName);
            
        }
    }
}