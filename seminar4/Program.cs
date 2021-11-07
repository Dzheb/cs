// участники: Dzheb (Борис Джериев), Александр Сибирко
// Решение нечётных задач
// Почувствуй себя интерном
//  0. Вывести квадрат числа
//  1. По двум заданным числам проверять является ли первое квадратом второго
//  2. Даны два числа. Показать большее и меньшее число
//  3. По заданному номеру дня недели вывести его название
//  4. Найти максимальное из трех чисел
//  5. Написать программу вычисления значения функции y=f(a)
//  6. Выяснить является ли число чётным
//  7. Показать числа от -N до N
//  8. Показать четные числа от 1 до N
//  9. Показать последнюю цифру трёхзначного числа
// 10. Показать вторую цифру трёхзначного числа
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
// 12. Удалить вторую цифру трёхзначного числа
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// 14. Найти третью цифру числа или сообщить, что её нет


//  1. По двум заданным числам проверять является ли первое квадратом второго
int a1 = 7;
int b1 = 3;
Console.WriteLine(IsPow(a1, b1));
bool IsPow(int a1, int b1)
{
  return (Math.Pow(b1, 2) == a1);
}
//  3. По заданному номеру дня недели вывести его название
int day3 = 2;
string[] days3 = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
Console.WriteLine(NameDay(days3, day3));

string NameDay(string[] days33, int day33)
{
  return days33[day33 - 1];

}
//  5. Написать программу вычисления значения функции y=f(a)
// sin а букв фамилии sin(а)^[кол-во букв Фамилии]
int a5 = 6;// радиан

string Fam = "Иванов";

int nFam = Fam.Length;

Console.WriteLine(FamSin(a5, nFam));

double FamSin(int a5, int nFam)
{
  return Math.Pow(Math.Sin(a5), nFam);
}

//  7. Показать числа от -N до N
int n7 = 7;
int k = n7 * 2 + 1;
int[] arresult = new int[k];
arresult = Arr7(n7);
for (int i = 0; i < arresult.Length; i++)
{
  Console.WriteLine(arresult[i]);
}


int[] Arr7(int n7)
{
  int k = n7 * 2 + 1;
  int[] arres = new int[k];
  int firstel = -n7;
  for (int i = 0; i < k; i++)
  {
    arres[i] = firstel;
    firstel++;
  }
  return arres;
}
//  9. Показать последнюю цифру трёхзначного числа
int c9 = 648;

Console.WriteLine("Задача 9");
Console.WriteLine(LastNum(c9));

int LastNum(int c9)
{
  return c9 % 10;

}
// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int n11 = 87;
Console.WriteLine($"Наибольшая цифра числа {n11} равна {MaxNum(n11)}");

int MaxNum(int n11)
{
  int firstnum = n11 / 10;
  int lastnum = n11 % 10;
  if (firstnum > lastnum) return firstnum;
  else return lastnum;
}
// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
int a = 15;
int b = 5;
Console.WriteLine(a);
Console.WriteLine(b);
int result = a / b;
if (a % b == 0)
{
  Console.WriteLine("Кратно");
}
else
{
  System.Console.WriteLine("Остаток = " + a % b);

}

// Почувствуй себя джуном
// 15. Дано число. Проверить кратно ли оно 7 и 23
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
// 17. По двум заданным числам проверять является ли одно квадратом другого
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
// 20. Задать номер четверти, показать диапазоны для возможных координат
// 21. Программа проверяет пятизначное число на палиндромом.
// 22. Найти расстояние между точками в пространстве 2D/3D

// 15.
//int n15 = new Random().Next(1, 1000);
int n15 = 161;
if (Is7and23(n15))
{
  Console.WriteLine($"Число {n15} кратно 7 и 23");
}
else
  Console.WriteLine($"Число {n15} не кратно 7 и 23");

bool Is7and23(int n15)
{
  if (n15 % 7 == 0)
  {
    if (n15 % 23 == 0) return true;
  }
  return false;

}
// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
int dayoweek = new Random().Next(1, 7);
if (IsHolly(dayoweek))
{
  Console.WriteLine($"{dayoweek} -й день Выходной");
}
else
{
  Console.WriteLine($"{dayoweek} -й день Рабочий");
}

bool IsHolly(int dow)
{
  if (dow == 6 || dow == 7)
  {
    return true;
  }
  return false;
}
// 21. Программа проверяет пятизначное число на палиндромом.

int n21 = 34843;

if (NumDec(n21, 1) == NumDec(n21, 5) && NumDec(n21, 2) == NumDec(n21, 4))
{
  Console.WriteLine($"Число {n21} палиндром");
}
else
{
  Console.WriteLine($"Число {n21}  не палиндром");
}

// нахождение цифры десятичного разряда n
int NumDec(int num, int n)
{
  if (n == 1)
  {
    return num % 10;
  }
  return num / Pow10(n - 1) % Pow10(1);
}

// возведение 10 в степень n
int Pow10(int npow)
{
  int res = 1;
  for (int i = 0; i < npow; i++)
  {
    res = res * 10;
  }
  return res;
}
