using System;

namespace My_firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double z = x % 4; // 2, остаток от деления целочисленного
            int a = 4;
            int b = ++a;

            int c = 4;
            int d = c++;

            int e = 4;
            int f = --e;

            int j = 4;
            int k = j--;
                       
            Console.WriteLine($"a = {a} b = {b} префиксный инкримент");
            Console.WriteLine($"c {c} d = {d} постфиксный инкримент");
            Console.WriteLine($"e = {e} f = {f} префиксный декримент");
            Console.WriteLine($"j = {j} k = {k} постфиксный декримент");

            Console.ReadKey();
            
        }
    }
}
