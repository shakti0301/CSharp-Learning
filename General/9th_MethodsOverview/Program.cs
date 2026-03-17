using System;

class Program
{
    static void Main()
    {
        // -------------------------------
        // 1. Stateless Method (No object needed)
        // -------------------------------
        Console.WriteLine("=== Stateless Method Example ===");
        Console.WriteLine("Hello, Shakti!");
        Console.WriteLine(); // Overloaded method (no parameter)


        // -------------------------------
        // 2. Creating Object (Instance)
        // -------------------------------
        Console.WriteLine("=== Creating Object ===");
        Random dice = new Random();   // creating object using new


        // -------------------------------
        // 3. Calling Stateful Method
        // -------------------------------
        Console.WriteLine("=== Stateful Method Example ===");

        int roll = dice.Next(1, 7);  // returns value between 1 and 6
        Console.WriteLine("Dice Roll: " + roll);


        // -------------------------------
        // 4. Using Return Value Directly
        // -------------------------------
        Console.WriteLine("=== Direct Return Value Usage ===");

        Console.WriteLine("Random Number: " + dice.Next(1, 100));


        // -------------------------------
        // 5. Ignoring Return Value (Not recommended)
        // -------------------------------
        Console.WriteLine("=== Ignoring Return Value ===");

        dice.Next(1, 10); // value generated but not used
        Console.WriteLine("Value was generated but not used");


        // -------------------------------
        // 6. Method Parameters & Arguments
        // -------------------------------
        Console.WriteLine("=== Parameters and Arguments ===");

        int number = -10;
        int absoluteValue = Math.Abs(number); // parameter = number
        Console.WriteLine("Absolute value of -10: " + absoluteValue);


        // -------------------------------
        // 7. Overloaded Methods Example
        // -------------------------------
        Console.WriteLine("=== Method Overloading ===");

        int roll1 = dice.Next();          // no parameter
        int roll2 = dice.Next(50);        // one parameter (0–49)
        int roll3 = dice.Next(10, 20);    // two parameters (10–19)

        Console.WriteLine("Roll1 (no limit): " + roll1);
        Console.WriteLine("Roll2 (0-49): " + roll2);
        Console.WriteLine("Roll3 (10-19): " + roll3);


        // -------------------------------
        // 8. Working with string methods (Class Library usage)
        // -------------------------------
        Console.WriteLine("=== String Methods ===");

        string name = "shakti";

        Console.WriteLine("Original: " + name);
        Console.WriteLine("Uppercase: " + name.ToUpper());   // returns string
        Console.WriteLine("Lowercase: " + name.ToLower());   // returns string


        // -------------------------------
        // 9. Method without Parameters
        // -------------------------------
        Console.WriteLine("=== Method without Parameters ===");

        Console.WriteLine("Clearing console in 2 seconds...");
        System.Threading.Thread.Sleep(2000); // wait 2 seconds

        Console.Clear(); // no parameter method


        // -------------------------------
        // 10. Final Output
        // -------------------------------
        Console.WriteLine("Program Finished Successfully!");
    }
}