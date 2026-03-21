using System;

class Program
{
    static void Main()
    {
        // 1. Basic for loop
        Console.WriteLine("Basic Loop:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        // 2. Reverse loop
        Console.WriteLine("\nReverse Loop:");
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);
        }

        // 3. Skipping values
        Console.WriteLine("\nSkipping Values (i += 2):");
        for (int i = 0; i < 10; i += 2)
        {
            Console.WriteLine(i);
        }

        // 4. Using break
        Console.WriteLine("\nUsing Break:");
        for (int i = 0; i < 10; i++)
        {
            if (i == 4)
            {
                break;
            }
            Console.WriteLine(i);
        }

        // 5. Array iteration
        Console.WriteLine("\nArray Iteration:");
        string[] names = { "Alex", "Eddie", "David", "Michael" };

        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        // 6. Modify array using for loop
        Console.WriteLine("\nModify Array:");
        for (int i = 0; i < names.Length; i++)
        {
            if (names[i] == "David")
            {
                names[i] = "Sammy";
            }
        }

        // Print updated array
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}