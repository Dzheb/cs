using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ex001Factorial
{
  class Program
  {
    static int countFR = 0;
    static int countFI = 0;

    static double FactorialRecursion(int n)
    {
      countFR++;
      return n == 0 ? 1 : n * FactorialRecursion(n - 1);
    }

    static double FactorialIteration(int n)
    {
      double result = 1;
      countFI++;
      for (int i = n; i > 1; i--)
      {
        countFI++;
        result *= i;
      }
      return result;
    }
    static int Fibonachi(int n)
    {
      if (n == 0 || n == 1) return n;

      return Fibonachi(n - 1) + Fibonachi(n - 2);
    }
    static int FibonachiIt(int n)
    {
      int result = 0;
      int b = 1;
      int tmp;

      for (int i = 0; i < n; i++)
      {
        tmp = result;
        result = b;
        b += tmp;
      }

      return result;
    }



    static void Main(string[] args)
    {
      int n = 30;
      double ResFact;

      Console.WriteLine("Время расчёта через рекурсию");
      DateTime dt = DateTime.Now;
      ResFact = FactorialRecursion(n);
      //ResFact = FactorialIteration(n);
      Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

      // Console.WriteLine("Время расчёта через итерацию");
      // dt = DateTime.Now;
      // //ResFact = FactorialIteration(n);
      // ResFact = FactorialRecursion(n);
      // Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

      Console.WriteLine($"n({n}) = {FactorialRecursion(n)} countFR = {countFR}");
      Console.WriteLine($"n({n}) = {FactorialIteration(n)} countFI = {countFI}");
      //Console.ReadLine();

      // вычисление чискл Фибоначчи
      int fib4 = Fibonachi(4);
      int fib5 = FibonachiIt(5);
      int fib6 = Fibonachi(6);

      Console.WriteLine($"4 число Фибоначчи = {fib4}");
      Console.WriteLine($"5 число Фибоначчи = {fib5}");
      Console.WriteLine($"6 число Фибоначчи = {fib6}");

    }
  }
}
// вывод - для экономии времени надо использовать циклы вместо роекурсии