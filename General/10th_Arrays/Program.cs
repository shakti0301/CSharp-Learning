using System;
 namespace _10th_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
                // -------------------------------
                // 1. Declare and initialize array
                // -------------------------------
                string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

                // -------------------------------
                // 2. Access elements using index
                // -------------------------------
                Console.WriteLine("Initial Order IDs:");
                Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
                Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
                Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

                // -------------------------------
                // 3. Reassign value
                // -------------------------------
                fraudulentOrderIDs[0] = "F000";
                Console.WriteLine($"\nAfter Reassignment:");
                Console.WriteLine($"First: {fraudulentOrderIDs[0]}");

                // -------------------------------
                // 4. Length of array
                // -------------------------------
                Console.WriteLine($"\nTotal orders: {fraudulentOrderIDs.Length}");

                // -------------------------------
                // 5. Loop using foreach
                // -------------------------------
                Console.WriteLine("\nAll Order IDs:");
                foreach (string order in fraudulentOrderIDs)
                {
                    Console.WriteLine(order);
                }

                // -------------------------------
                // 6. Inventory Example (Sum + Running Total)
                // -------------------------------
                int[] inventory = { 200, 450, 700, 175, 250 };

                int sum = 0;
                int bin = 0;

                Console.WriteLine("\nInventory Details:");

                foreach (int items in inventory)
                {
                    sum += items;   // add items to total
                    bin++;          // increase bin number

                    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
                }

                Console.WriteLine($"Total items in inventory: {sum}");

                // -------------------------------
                // 7. Fraud Detection (Condition + Loop)
                // -------------------------------
                string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

                Console.WriteLine("\nFraudulent Orders (Start with 'B'):");

                foreach (string orderID in orderIDs)
                {
                    if (orderID.StartsWith("B"))
                    {
                        Console.WriteLine(orderID);
                    }
                }
        }
    }
}