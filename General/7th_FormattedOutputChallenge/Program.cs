using System;
namespace FormattedOutputChallenge
{
    
    class Program
    {
        static void Main()
        {
            // -----------------------------------------
            // Challenge: Format Output
            // -----------------------------------------

            string projectName = "ACME";

            string russianMessage =
            "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c " +
            "\u0440\u0443\u0441\u0441\u043a\u0438\u0439 " +
            "\u0432\u044b\u0432\u043e\u0434";

            // English output
            Console.WriteLine($"View English output:\n\tc:\\Exercise\\{projectName}\\data.txt\n");

            // Russian output
            Console.WriteLine($"{russianMessage}:\n\tc:\\Exercise\\{projectName}\\ru-RU\\data.txt");
        }
    }
}