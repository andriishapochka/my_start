using System;

namespace My_firstApp
{
    class Program
    {
        static void Main(string[] args) // логические операции
        {
            // & | ^ ~

           int x1 = 2; // 010
           int y1 = 5; // 101
                       // 000 - 0

            Console.WriteLine(x1 & y1); // логическое умножение

            int x2 = 4; // 100
            int y2 = 5; // 101
                        // 100 - 4

            Console.WriteLine(x2 & y2);
            Console.ReadKey();


        }
        //static void Main(string[] args) // инкрименто, декрименто, отстаток от деления целочисленного
        //{


        //    ////double x = 10;
        //    //double z = x % 4; // 2, остаток от деления целочисленного
        //    //int a = 4;
        //    //int b = ++a;

        //    //int c = 4;
        //    //int d = c++;

        //    //int e = 4;
        //    //int f = --e;

        //    //int j = 4;
        //    //int k = j--;
                       
        //    //Console.WriteLine($"a = {a} b = {b} префиксный инкримент");
        //    //Console.WriteLine($"c {c} d = {d} постфиксный инкримент");
        //    //Console.WriteLine($"e = {e} f = {f} префиксный декримент");
        //    //Console.WriteLine($"j = {j} k = {k} постфиксный декримент");

        //    //Console.ReadKey();
            
        //}
    }
}
