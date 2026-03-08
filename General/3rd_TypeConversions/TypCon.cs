using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion
            byte a = 1;  // 0000 0001
            int b = a;   // 000 0000 0000 0000 0000 0000 0000 0001
            // Implicit conversion happens when there is no risk of data loss. In this case, a byte can be safely converted to an int without any issues.

            int c = 100;
            double d = c; // 100.0
            // Here, an int can be implicitly converted to a double because a double has a larger
            // range and can represent all int values without loss of precision.

            // Explicit Conversion (Casting)
            int e = 1000;
            // byte f = e; // This will cause a compile-time error because there is a risk of data loss.
            byte f = (byte)e; // This will compile, but it will result in data loss because 1000 exceeds the maximum value of a byte (255). The value of f will be 232 (1000 mod 256).
            Console.WriteLine($"Value of f after casting: {f}"); // Output: Value of f after casting: 232

            double g = 3.14;
            int h = (int)g; // This will truncate the decimal part and result in h being 3. This is an example of explicit conversion where the programmer is responsible for ensuring that the conversion is valid and does not lead to unintended consequences.
            Console.WriteLine($"Value of h after casting: {h}"); // Output: Value of h after casting: 3

            string str = "123";
            //int i = (int)str; // This will cause a compile-time error because you cannot directly cast a string to an int. You need to use a method like int.Parse() or int.TryParse() to convert the string to an integer. 
            int i = int.Parse(str); // This will convert the string "123" to the integer 123. However, if the string cannot be parsed to an integer (e.g., "abc"), it will throw a FormatException. To avoid this, you can use int.TryParse() which returns a boolean indicating whether the conversion was successful or not.
            Console.WriteLine($"Value of i after parsing: {i}"); // Output: Value of i after parsing: 123

            // ToByte() - This method is used to convert a value to a byte. 
            // ToInt16() - This method is used to convert a value to a short (Int16).
            // ToInt32() - This method is used to convert a value to an int.
            // ToInt64() - This method is used to convert a value to a long (Int64).
            
        }
    }
}