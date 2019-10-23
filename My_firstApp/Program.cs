using System;

namespace My_firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var apple = "Apple";

            var index = 5; //визначає як int, якщо вже призначений тип - не можемо їй призначити інший тип

            object obj2 = "Hello World";

            object obj = 2;

            string hello = "Hello";

            char a = 'A';

            decimal rate = 2.2M;

            double weight = 111.25;

            float hight = 234.17F;

            byte b = 3;//0-255

            bool isAlive = true;
            isAlive = false; // 1 байт 

            int tax = 9; //ініціалізація-присвоєння значення змінної при її визначенні 
           
            Console.WriteLine(tax);

            Console.WriteLine(hello);

            Console.WriteLine(obj2);

            Console.ReadKey();
        }
    }
}
