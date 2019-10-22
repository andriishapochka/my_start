using System;

namespace My_firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator.Add(2, 3);
            Console.ReadKey();
            
        }
    }
    class Calculator
    {
        public static void Add(int x, int y)
        {
            int z = x + y;
            Console.WriteLine($"Сума {x} та {y} дорiвнює {z}");
        }
    }
}
