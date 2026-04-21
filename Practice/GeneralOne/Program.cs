using System;
using System.Security.Cryptography;

namespace GeneralOne
{
    class Student
    {
        private int[] marks = new int[5];

        public int this[int index]
    {
        get
        {
            if (index >= 0 && index < marks.Length)
            {
                return marks[index];
            }
            else
            {
                Console.WriteLine("Invalid index!");
                return 0;
            }
        }
        set
        {
            if (index >= 0 && index < marks.Length)
            {
                marks[index] = value;
            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }
    }
    }
    class Program
    {
        static void Main()
        {
            
        }
    }
}