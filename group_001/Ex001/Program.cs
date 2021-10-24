using System;

namespace Ex001
{
    class Program
    {
        static void Main(string[] args)
        {

            // типы данных
            // int, double, string, boolean
            // Сколько типов данных ~20 000
            int a = 2_000_000_000, b = 1_000_000_000;
            int c = a;
           
            //Console.WriteLine("Привет Мир!");
            //Console.WriteLine(sizeof(int));
            //Console.Write($"a: {a}  b:{b}");
            //Console.Write("a: "+ a+ " b: " +b);
            //Console.Write(sizeof(int));
            // поменять значения местами

             
             a = 1;
             b = 2;
            
             if (a > b)
             {
                 Console.WriteLine($"a: {a}");
             }
             else
             {
                 Console.WriteLine($"b: {b}");
             }

             a = 123;
             b = 321;
            int max;
             if (a > b)
             {
                 max = a;
                 
             }
             else
             {
                 max = b;
                 
             }
             Console.WriteLine($"max: {max}");

//int count = 1;
//while (count <= 100)
//{
//     Console.WriteLine($"count: {count}");
//     count++;
//}

//количество чисел которое делится на 3 и на 5 из отрезка [2,128]
int number_end = 128;
int number_start = 2;
int count = 0;
while (number_start <= number_end)
{
    if ((number_start%3) == 0 && (number_start%5 == 0))
    {
        count++;
        Console.WriteLine(number_start);
    }
     number_start++;
}
Console.WriteLine($"count: {count}");

//bool flag1 = (10 % 3) == 0;
//bool flag2 = (10 % 5) == 0;
//bool result = (flag1 && flag2);
//Console.WriteLine($"flag1: {flag1}"); 
//Console.WriteLine($"flag2: {flag2}"); 
//Console.WriteLine($"result: {result}"); 
// домашняя работа с собаками по алгоритму

        }
   }
}
