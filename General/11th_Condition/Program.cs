using System;

class Program
{
    static void Main()
    {
        int marks = 85;
        string grade;

        if (marks >= 90)
        {
            grade = "A";
        }
        else if (marks >= 80)
        {
            grade = "B";
        }
        else if (marks >= 70)
        {
            grade = "C";
        }
        else if (marks >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Grade using if-else: {grade}");
    }
}