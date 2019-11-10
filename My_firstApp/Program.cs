using System;

namespace My_firstApp
{
    struct User//структура пределяется вне класса- определяем переменные

    {
       public string name;
       public int age;

        public void DisplayInfo() 
        {
            Console.WriteLine($"name={name} age={age}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            User tom;
            tom.name = "Tom";
            tom.age = 23;
            int d = tom.age;

            tom.DisplayInfo();
        Console.ReadKey();

        }
        string name = "Tom";
        int age = 23;
        
    }
}
//    class Program
//    {//перечесление может быть в пределах класса програм или вне класа в пределах пространства имён 
        
//        static void Main(string[] args)
//        {
//            ApplyOperation(10, 15, Operation.Add);//25
//            ApplyOperation(10, 15, Operation.Multiply);//150
//            Console.ReadKey();

//        }
//        enum Operation
//        {
//            Add,
//            Subtract,
//            Multiply,
//            Divide
//        }
//        static void ApplyOperation(double x, double y, Operation op)
//        {
//            double result = 0.0;
//            switch (op)
//            {
//                case Operation.Add:
//                    result = x + y;
//                    break;
//                case Operation.Subtract:
//                    result = x - y;
//                    break;
//                case Operation.Multiply:
//                    result = x * y;
//                    break;
//                case Operation.Divide:
//                    result = x / y;
//                    break;
//            }
//            Console.WriteLine(result);

//        }
//    }
//}
//class Program
//{//перечесление может быть в пределах класса програм или вне класа в пределах пространства имён 
//    enum Days// перечисление- логически связанные константы(можно указать тип перечисления- по умолчанию int и присваивается от 0 и віше на единицу)
//    {
//        Monday = 1,//по умолчанию присвоится один, или присваиваем сами
//        Tuesday = 11,
//        Wednesday = 22,
//        Thursday = 33,
//        Friday,// 34
//        Saturday,
//        Sunday//кроме после последнего не ставится запятая
//    }
//    static void Main(string[] args)
//    {
//        Days day;
//        day = Days.Friday;
//        Console.WriteLine(day);
//        Console.ReadKey();

//    }
//        static void Main(string[] args)
//        {
//            Addition(new int[] { 1, 2, 3, 4 }); //МОЖНО РАЗНЫМ СПОСОБОМ ВНОСИТЬ ПАРАМЕТРЫ
//            Addition(2, 3, 4, 5);
//            Addition();
//        }
//        static void Addition(params int[] numbers)
//        {
//            int result = 0;
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                result += numbers[i];

//            }
//            Console.WriteLine(result);
//            Console.ReadKey();
//        }
//    }
//}

//    {
//        //назначеная переменная внутри блока вызывается только внутри блока
//        //переменная на уровне метода скрывает переменную на уровне класса
//        //не можем в рамкам даннго класса определить переменную с таким же именем

//        static int x = 10;

//        static void Main(string[] args)
//        {
//            int x = 25;
//            Console.WriteLine(x);
//            Console.ReadKey();

//        }
//    }
//}

//        static int Fibonachi(int n) // рекурсивные функции (ряд фибоначи)
//        {
//            if (n == 0)
//                return 0;
//            if (n == 1)
//                return 1;
//            else
//                return Fibonachi(n - 1) + Fibonachi(n - 2);
//        }
//        static void Main(string[] args)
//        {
//            int x = Fibonachi(8);

//            Console.WriteLine(x);
//            Console.WriteLine(Fibonachi(4));
//            Console.WriteLine(Fibonachi(6));
//            Console.ReadKey();

//        }

//    }
//}
//    //{
//    //    //именованные параметры (может быть изменён порядок передачи значения))
//    //    int d1 = Optional(x:1,z:3, s:4, y:2); //именованные параметры
//    //    int d2 = Optional(1,2,3);
//    //}


////    Console.ReadKey();

//            static int Optional(int x, int y, int z = 5, int s = 7)
//    {
//        return x + y + z + s;
//    }
//}
//int perimeter;
//int area;
//GetData(10, 15, out area, out perimeter);
//Console.WriteLine($"Area = {area}");
//Console.WriteLine($"Perimeter = {perimeter}");
//Console.ReadKey();



//static void GetData(int width, int height, out int area, out int perimeter)
//{
//    perimeter = (width + height) * 2;

//    area = width * height;
//}

//int z = 5;
//int d = 6;
//// ввод параметров по значению ( используется копия значения и после выполнения метода не изменяется параметр вариант 2)
//Console.WriteLine($"Initial value z= {z}");
//AdditionVal(z, d);
//Console.WriteLine($"After AdditionVal z= {z}");
//AdditionVal(z, d);
//Console.WriteLine($"2After AdditionVal z= {z}");
////    //// ввод параметрв по ссылке (используется само значение которое изменяется после выполнения метода вариант 2)
////    //AdditionRef(ref z, d);
////    //Console.WriteLine($"After AdditionRef z= {z}");
////    //AdditionRef(ref z, d);
////    //Console.WriteLine($"2After AdditionRef z= {z}");

////    //Console.ReadKey();
////}

//static void AdditionRef(ref int x, int y)
//{
//    x = x + y;
//    Console.WriteLine($"AdditionRef x={x}");

//}

//static void AdditionVal(int x, int y)
//{
//    x= x + y;
//    Console.WriteLine($"AdditionVal x={x}");
//}

//static int Sum(int x, int y)

//{
//   return x + y;
//}



//{
//    int[] numbers = { 1, 3, 5, 7 };

//    for (int i = 0; i < 4; i++)// выведение значения массива с помощью for
//    {
//        Console.WriteLine(numbers[i]);

//    }
//    Console.ReadKey();
//}

//int[] numbers0 = { 1, 3, 5, 7 };// выведение значения массива с помощью foreach 
//foreach(int i in numbers0)
//{
//    Console.WriteLine(i);
//}

//Console.ReadKey();

//    int[] numbers = new int[4] { 1, 2, 3, 4 }; // инициализация с ключ. new и указанием размера массива
//    int n = numbers[0]; // 1
//    numbers[0] = 7;
//    Console.WriteLine(numbers[3]);


//    int[] numbers2 = { 2, 4, 6, 8 }; // без использования ключевого слова new
//    int t = numbers[0] = 5;
//    Console.WriteLine(numbers2[3]);

//    int[] numbers3 = new[] { 1, 3, 5, 7 };// иниц. с ключ словом new и без указания размера массива

//    Console.WriteLine(numbers3[2]);
//    Console.ReadKey();
//}

//static void Main(string[] args)
//{
//    int[] numbers = { 1, 2, 3, 4 }; // 0-3
//    int n = numbers[0]; // 1
//    numbers[0] = 7;
//    Console.WriteLine(numbers[0]);
//    Console.WriteLine(numbers[1]);
//    Console.WriteLine(numbers[2]);
//    Console.WriteLine(numbers[3]);
//    Console.ReadKey();

//}
//static void Main(string[] args) // факториал шахматнй доски


//{
//int n = 64;
//double result = 1;
//for (int i = 1; i<=n; i++)
//  {
//        result = result * i;
//  }
//    Console.WriteLine(result);
//    Console.ReadKey();
//}

//static void main(string[] args)
//{
//        byte a = 4;
//        int b = a + 70; // расширяющее преобразвание
//        // byte->short->int->long->decimal //компилятор преобразование производит сам
//        //byte->short->int->double  //компилятор преобразование производит сам
//        //byte->short->float->double //компилятор преобразование производит сам
//        //char->int   //компилятор преобразование производит сам
//        Console.WriteLine(b);
//        Console.ReadKey();


//static void Main(string[] args) // логические операции

// & | ^ ~
// XOR


//int x1 = 2; // 010
//int y1 = 5; // 101
//            // 000 - 0

// Console.WriteLine(x1 & y1); // логическое умножение

// int x2 = 4; // 100
// int y2 = 5; // 101
//             // 100 - 4

// Console.WriteLine(x2 & y2);
// Console.ReadKey();



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


