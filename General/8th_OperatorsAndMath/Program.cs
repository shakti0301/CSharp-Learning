using System;

namespace OperatorsAndMath
{
    class Program
    {
        static void Main()
        {
            // -------------------------------------------------
            // 1. BASIC MATH OPERATIONS
            // -------------------------------------------------

            int a = 7;
            int b = 5;

            int sum = a + b;          // Addition
            int difference = a - b;   // Subtraction
            int product = a * b;      // Multiplication
            int quotient = a / b;     // Integer division (decimal part removed)

            Console.WriteLine("=== Basic Math Operations ===");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient (int division): {quotient}");
            Console.WriteLine();


            // -------------------------------------------------
            // 2. DECIMAL DIVISION
            // -------------------------------------------------
            // Using decimal numbers keeps values after decimal point

            decimal decimalQuotient = 7.0m / 5.0m;

            Console.WriteLine("=== Decimal Division ===");
            Console.WriteLine($"Decimal Quotient: {decimalQuotient}");
            Console.WriteLine();


            // -------------------------------------------------
            // 3. CASTING (TYPE CONVERSION)
            // -------------------------------------------------
            // Converting int values to decimal before division

            int first = 7;
            int second = 5;

            decimal castResult = (decimal)first / second;

            Console.WriteLine("=== Casting Example ===");
            Console.WriteLine($"Result after casting: {castResult}");
            Console.WriteLine();


            // -------------------------------------------------
            // 4. MODULUS OPERATOR
            // -------------------------------------------------
            // % gives the remainder after division

            Console.WriteLine("=== Modulus Operator ===");
            Console.WriteLine($"200 % 5 = {200 % 5}");
            Console.WriteLine($"7 % 5 = {7 % 5}");
            Console.WriteLine();


            // -------------------------------------------------
            // 5. ORDER OF OPERATIONS (PEMDAS)
            // -------------------------------------------------

            int value1 = 3 + 4 * 5;      // Multiplication happens first
            int value2 = (3 + 4) * 5;    // Parentheses change the order

            Console.WriteLine("=== Order of Operations ===");
            Console.WriteLine($"3 + 4 * 5 = {value1}");
            Console.WriteLine($"(3 + 4) * 5 = {value2}");
            Console.WriteLine();


            // -------------------------------------------------
            // 6. INCREMENT AND DECREMENT
            // -------------------------------------------------

            int value = 1;

            value++; // increment by 1
            Console.WriteLine("First increment: " + value);

            value += 2; // add 2
            Console.WriteLine("Second increment: " + value);

            value--; // decrement by 1
            Console.WriteLine("First decrement: " + value);

            value -= 2; // subtract 2
            Console.WriteLine("Second decrement: " + value);
            Console.WriteLine();


            // -------------------------------------------------
            // 7. PREFIX VS POSTFIX INCREMENT
            // -------------------------------------------------

            int number = 1;

            Console.WriteLine("=== Prefix vs Postfix ===");

            Console.WriteLine($"Original value: {number}");

            Console.WriteLine($"Postfix increment: {number++}"); 
            // value used first, then increment

            Console.WriteLine($"Value after postfix: {number}");

            Console.WriteLine($"Prefix increment: {++number}");
            // increment first, then value used

            Console.WriteLine();


            // -------------------------------------------------
            // 8. REAL EXAMPLE: FAHRENHEIT TO CELSIUS
            // -------------------------------------------------

            int fahrenheit = 94;

            decimal celsius = (fahrenheit - 32) * 5m / 9m;

            Console.WriteLine("=== Temperature Conversion ===");
            Console.WriteLine($"The temperature is {celsius:F1} Celsius.");
        }
    }
}