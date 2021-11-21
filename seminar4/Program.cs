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
// 23. Показать таблицу квадратов чисел от 1 до N
// 24. Найти кубы чисел от 1 до N
// 25. Найти сумму чисел от 1 до А
// 26. Возвести число А в натуральную степень В используя цикл
// 27. Определить количество цифр в числе
// 28. Подсчитать сумму цифр в числе
// 29. Написать программу вычисления произведения чисел от 1 до N
// 30. Показать кубы чисел, заканчивающихся на четную цифру
//
// Почувствуй себя сеньором*
// 31. Задать массив из 8 элементов и вывести их на экран
// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
// 34. Написать программу замену элементов массива на противоположные
// 35. Определить, присутствует ли в заданном массиве, некоторое число
// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

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
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool x18 = true;
bool y18 = false;
bool exp18one = !(x18 && y18);
bool exp18two = !x18 || !y18;
Console.WriteLine($"Выражение ¬(X ⋁ Y) = ¬X ⋀ ¬Y истинно ? {CheckBool(exp18one, exp18two)}");
// проверка истинности выражения
bool CheckBool(bool exp18one, bool exp18two)
{
  return exp18one == exp18two;
}
// 19. Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
int x19 = 1;
int y19 = -1;

Console.WriteLine($"Точка x: {x19}  y: {y19} принадлежит {NumQuarter(x19, y19)} четверти");

string NumQuarter(int x19, int y19)
{
  string res = "";
  if (x19 > 0 && y19 > 0) res = "первой";
  if (x19 < 0 && y19 > 0) res = "второй";
  if (x19 < 0 && y19 < 0) res = "третьей";
  if (x19 > 0 && y19 < 0) res = "четвёртой";
  return res;
}

// 21. Программа проверяет пятизначное число на палиндромом.
int n21 = 34043;

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
// 22. Найти расстояние между точками в пространстве 2D/3D
// для 2D
int[] coora2 = { 2, 7 };
int[] coorb2 = { 7, 8 };
Console.WriteLine(LenVec2(coora2, coorb2));
double LenVec2(int[] a, int[] b)
{
  int ax = a[0];
  int ay = a[1];
  int bx = b[0];
  int by = b[1];
  return Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2));
}
// для 3D
int[] coora3 = { 2, 2, 1 };
int[] coorb3 = { 7, 8, 1 };
Console.WriteLine(LenVec(coora3, coorb3));
double LenVec(int[] a, int[] b)
{
  int ax = a[0];
  int ay = a[1];
  int az = a[2];
  int bx = b[0];
  int by = b[1];
  int bz = b[2];
  return Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
}
// 23. Показать таблицу квадратов чисел от 1 до N
int N = 10;
int[] array = new int[10];
for (int i = 0; i < N; i++)
{
  array[i] = (i + 1) * (i + 1);
}
System.Console.WriteLine("Задача 23");
PrintArray(array);

// 24. Найти кубы чисел от 1 до N
int N24 = 10;
int[] array24 = new int[N24];
for (int i = 0; i < N24; i++)
{
  array[i] = (i + 1) * (i + 1) * (i + 1);
}
System.Console.WriteLine("Задача 24");
PrintArray(array);

// 25. Найти сумму чисел от 1 до А
int A = 10;

Console.WriteLine($"Сумма чисел от 1 до А: {SumNum(A)}");

int SumNum(int A)
{
  int res = 0;
  for (int i = 1; i <= A; i++)
  {
    res = res + i;
  }
  return res;
}
// 26. Возвести число А в натуральную степень В используя цикл
int a26 = 4;
int b26 = 3;
Console.WriteLine($"{a26} в степени {b26}: {Power(a26, b26)} ");

int Power(int a26, int b26)
{
  int res = 1;
  for (int i = 0; i < b26; i++)
  {
    res = res * a26;
  }
  return res;
}
// 27. Определить количество цифр в числе
int n27 = 57346;
Console.WriteLine($"Количество цифр в числе {n27} :{HowMany(n27)}");

int HowMany(int n27)
{
  int res = 1;
  while (n27 / Pow10(res) != 0)
  {
    res++;
  }
  return res;
}
// 28. Подсчитать сумму цифр в числе
int n28 = 95038;
int n28len = HowMany(n28);
Console.WriteLine($"Сумма цифр в числе {n28} :{SumN(n28, n28len)}");

int SumN(int num, int numlen)
{
  int res = 0;
  for (int i = 1; i <= numlen; i++)
  {
    res = res + NumDec(num, i);
  }
  return res;
}

// 29. Написать программу вычисления произведения чисел от 1 до N
int N29 = 9;
Console.WriteLine($"Факториал {N29} равен  {Fact(N29)} ");

int Fact(int N29)

{
  int res = 1;
  for (int i = 1; i <= N29; i++)
  {
    res = res * i;
  }
  return res;
}
// 30. Показать кубы чисел, заканчивающихся на четную цифру
int N30 = 10;
int[] array30 = new int[N30];
Console.WriteLine("Массив кубов чисел");
PrintArray(FillArrayCube(array30));
Console.WriteLine("Массив чётных кубов чисел");
PrintArray(ContCubeEven(FillArrayCube(array30)));
Console.WriteLine("Конец Задачи 30");

// создание массива кубов чисел
int[] FillArrayCube(int[] arraycube)
{
  int count = arraycube.Length;
  int[] result = new int[count];
  for (int i = 0; i < count; i++)
  {
    result[i] = i * i * i;
  }
  return result;
}
// создание массива чётных кубоа чисел
int[] ContCubeEven(int[] numcubes)
{
  int numeven = 0;
  for (int i = 0; i < numcubes.Length; i++)
  {

    if (numcubes[i] % 2 == 0) numeven++;
  }
  int[] res = new int[numeven];
  int evencount = 0;
  for (int i = 0; i < numcubes.Length; i++)
  {
    if (numcubes[i] % 2 == 0)
    {
      res[evencount] = numcubes[i];
      evencount++;
    }
  }
  return res;
}


// 31. Задать массив из 8 элементов и вывести их на экран
int count31 = 8;
int[] arr31 = CreateArray(count31);
Console.WriteLine("Задача 31");
FillArray(arr31);
PrintArray(arr31);

// 33. Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива

int[] arr33 = new int[12];
int[] arr33test = new int[12];
arr33test = FillArr33(arr33);
//PrintArray(arr33test);
Console.WriteLine($"Задача 33 сумма равна : {SumArr33pos(arr33test)}");
Console.WriteLine($"Задача 33 сумма отрицательных : {SumArr33neg(arr33test)}");

int[] FillArr33(int[] arr33)
{
  int[] res = new int[12];
  for (int i = 0; i < arr33.Length; i++)
  {
    res[i] = new Random().Next(-10, 10);
  }
  return res;
}

int SumArr33pos(int[] arr33)
{
  int res = 0;

  for (int i = 0; i < arr33.Length; i++)
  {
    if (arr33[i] > 0)
    {

      res = res + arr33[i];
    }
  }
  return res;
}
int SumArr33neg(int[] arr33)
{
  int res = 0;

  for (int i = 0; i < arr33.Length; i++)
  {
    if (arr33[i] < 0)
    {

      res = res + arr33[i];
    }
  }
  return res;
}

// 34. Написать программу замену элементов массива на противоположные
int[] arr34 = { -1, 0, 8, 6, -5, -9, 8, 4, -2, 0 };
arr34 = ChangeArrEl(arr34);

System.Console.WriteLine("Задача 34");
PrintArray(arr34);

int[] ChangeArrEl(int[] arr34)
{
  int[] res = new int[arr34.Length];
  for (int i = 0; i < arr34.Length; i++)
  {
    if (arr34[i] != 0) res[i] = -arr34[i];

  }
  return res;
}
// 35. Определить, присутствует ли в заданном массиве, некоторое число

int[] arr35 = FillArr35(200);
//int count35 = 200;
//int num35 = -9;

System.Console.WriteLine($"Задача 35 число 9 принадлежит массиву {IsNumIn(arr35, 9)}");
//PrintArray(arr35);

int[] FillArr35(int count35)
{
  int[] arr35 = new int[count35];
  for (int i = 0; i < arr35.Length; i++)
  {
    arr35[i] = new Random().Next(-200, 200);
  }
  return arr35;

}

bool IsNumIn(int[] arr35, int num35)
{
  for (int i = 0; i < arr35.Length; i++)
  {
    if (arr35[i] == num35)
    {
      //Console.WriteLine(arr35[i]);
      return true;
    }
  }

  return false;
}

// 36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] arr36 = FillArr36(10);
PrintArray(arr36);
Console.WriteLine($"Задача 36 количество чётных чисел: {ContEven(arr36)}");
Console.WriteLine($"Задача 36 количество нечётных чисел: {ContOdd(arr36)}");

int[] FillArr36(int count36)
{
  int[] arr36 = new int[count36];
  for (int i = 0; i < arr36.Length; i++)
  {
    arr36[i] = new Random().Next(100, 999);
  }
  return arr36;
}
int ContEven(int[] arr)
{
  int result = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 == 0)
    {
      result++;
    }
  }
  return result;
}
int ContOdd(int[] arr)
{
  int result = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] % 2 != 0)
    {
      result++;
    }
  }
  return result;
}
// 37. В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] arr37 = new int[123];
FillArray2(arr37, 0, 999);
Console.WriteLine("Задача 37");
PrintArray(arr37);
Console.WriteLine($"Количество элементов из отрезка [10,99] : {QuantNumArr(arr37, 10, 99)}");
int QuantNumArr(int[] arr, int minval, int maxval)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] >= minval && arr[i] <= maxval) res++;
  }
  return res;
}
// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] arr38 = new int[5];
FillArray2(arr38, 0, 999);
Console.WriteLine("Задача 38");
PrintArray(arr38);
Console.WriteLine($"Сумма нечетных элементов : {SumOddArr(arr38)}");
int SumOddArr(int[] arr)
{
  int res = 0;
  for (int i = 0; i < arr.Length; i++)
  {

    if (i % 2 != 0) res = res + arr[i];
  }
  return res;
}
// 39. Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// int[] arr3 9= new int[5];
// FillArray2(arr39, 0, 999);
// Console.WriteLine("Задача 39");
// PrintArray(arr39);
// Console.WriteLine($"Сумма пар элементов : {SumMariage(arr39)}");
// int SumMariage(int[] arr)
// {
//   int res = 0;
//   for (int i = 0; i < arr.Length; i++)
//   {

//     if (i % 2 != 0) res = res + arr[i];
//   }
//   return res;
// }
int[] Array(int count)
{
  int[] arr = new int[count];
  for (int i = 0; i < arr.Length; i++)
  {
    arr[i] = new Random().Next(1, 150);
  }
  return arr;
}
int[] arr39 = Array(10);
System.Console.WriteLine("Задача 39:");
PrintArrayS(arr39);
System.Console.WriteLine("Произведение пар чисел массива:");
PrintArrayS(Method2(arr39));

// int[] arr392 = Method2(arr39);

int[] Method2(int[] arr39)
{
  int length = arr39.Length;
  int length2 = length / 2;
  int[] arr392 = new int[length2];
  for (int i = 0; i < length2; i++)
  {
    // System.Console.WriteLine(i);
    // System.Console.WriteLine(length2);
    arr392[i] = arr39[i] * arr39[length - i - 1];
  }
  return arr392;
}
void PrintArrayS(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine($"{array[i]} ");
  }
}

// 40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] arr40 = new double[2];
FillArrayDouble(arr40, 10, 999);
Console.WriteLine("");
PrintArrayDouble(arr40);
Console.WriteLine("");
(double min, double max) minmax = MinMaxVal(arr40);
Console.WriteLine($"Задача 40 минимум {minmax.min} и максимум: {minmax.max}");
Console.WriteLine($"Разница между минимум и максимум: {minmax.max - minmax.min}");

(double min, double max) MinMaxVal(double[] arr)
{
  double min = arr[0];
  double max = arr[0];
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i];

  }

  return (min, max);
}
// Почувствуй себя лидом*
// 41. Выяснить являются ли три числа сторонами треугольника
// 42. Определить сколько чисел больше 0 введено с клавиатуры
// 43. Написать программу преобразования десятичного числа в двоичное
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, а1 k1 и а2 и k2 заданы
// 45. Показать числа Фибоначчи
// 46. Написать программу масштабирования фигуры
// 47. Написать программу копирования массива
//
//
// 41. Выяснить являются ли три числа сторонами треугольника
Console.WriteLine("Задача 41");
Console.WriteLine($"Отрезки 5, 5, 5 формируют {Triangle(5, 5, 5)}");

string Triangle(int a, int b, int c)
{
  string res = string.Empty;
  if ((a >= b + c) || (b >= a + c) || (c >= a + b))
    // не треугольник
    res = "не треугольник";
  else if (a == b && b == c)
    // равносторонний
    res = "равносторонний треугольник";
  else if ((a == b) || (a == c) || (b == c))
    // равнобедренный
    res = "равнобедренный треугольник";
  else
    res = "просто треугольник";
  // просто треугольник
  return res;
}

// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Задача 42 вариант 1");
string numbers = string.Empty;
System.Console.WriteLine("Введите числа через запятую '1,-2,3,...");
numbers = numbers + Console.ReadLine();
string[] num = ExError(numbers).Split(',');

Console.WriteLine($"Введено: {CountMoreZero(num)} чисел больше 0");

string ExError(string inputstring)
{
  string res = string.Empty;
  for (int i = 0; i < inputstring.Length; i++)
  {
    if (inputstring[i] >= 48 && inputstring[i] < 58 || inputstring[i] == 45)
    {
      res = res + inputstring[i];
      //
      if (i < inputstring.Length - 1)
      {

        if (inputstring[i + 1] <= 48 || inputstring[i + 1] > 58)
        {
          res = res + ',';
        }
      }


    }

  }
  return res;
}

int CountMoreZero(string[] stringarr)
{
  int count = 0;
  for (int i = 0; i < stringarr.Length; i++)
  {
    if (Convert.ToInt32(stringarr[i]) > 0) count++;
  }
  return count;
}


Console.WriteLine("Задача 42 вариант 2");

Console.WriteLine("Нажмите <Enter> для выхода... ");
ConsoleKeyInfo inch;
int res = 0;
do
{
  inch = Console.ReadKey();
  if (Convert.ToInt32(inch.Key) > 48 && Convert.ToInt32(inch.Key) < 58) res++;
  Console.WriteLine($"Введено {Convert.ToInt32(inch.Key)}");
}
while (inch.Key != ConsoleKey.Enter);
Console.WriteLine($"Введено {res} цифр больше 0");

// 43. Написать программу преобразования десятичного числа в двоичное
//string BinaryCode = Convert.ToString(123, 2);

Console.WriteLine(Convert.ToString(123, 2));
// int n43 = 999;
int n43 = 999;
Console.WriteLine($"Задача 43 {OverStr(IntToBin(n43))}");

string OverStr(string stringover)
{
  string res = string.Empty;
  for (int i = 0; i < stringover.Length; i++)
  {
    res = res + stringover[stringover.Length - i - 1];
  }
  return res;
}

string IntToBin(int num)
{
  string res = string.Empty;
  while (num >= 1)
  {
    res = res + $"{num % 2}";
    num /= 2;
  }
  return res;
}
// 44. Найти точку пересечения двух прямых заданных уравнением y=kx+b, b1 k1 и b2 и k2 заданы
// k1x + b1 = k2x + b2 => x(k1 - k2) = b2 - b1 => x = (b2 - b1) / (k1 - k2)
// y = k1x+b1
double k144 = 3;
double k244 = 5;
double b144 = 10;
double b244 = 5;

double pX = FindX(k144, k244, b144, b244);
double pY = k144 * pX + b144;
System.Console.WriteLine($"Задача 44 точка пересечения X = {pX} Y = {pY}");


double FindX(double k144, double k244, double b144, double b244)

{
  double res = (b244 - b144) / (k144 - k244);
  return res;
}

// 45. Показать числа Фибоначчи первые два числа равны 0 и 1, а каждое 
// последующее число равно сумме двух предыдущих чисел. 
System.Console.WriteLine("Задача 45");
PrintArray(Fibon(CreateArray(20)));

// int[] CreateArray(int count)
// {
//   int[] array = new int[count];
//   return array;
// }

int[] Fibon(int[] arr)
{
  arr[0] = 0; arr[1] = 1;
  int length = arr.Length;
  for (int i = 2; i < length;
   i++)
  {
    arr[i] = arr[i - 1] + arr[i - 2];
  }
  return arr;
}

// 46. Написать программу масштабирования фигуры

// x*x + y*y = r*r =>y = (r*r - x*x)/y
// int x46;
// int y46;
// int R46 = 10;
// Console.Clear();
// Console.SetWindowPosition(0, 0);
// for (x46 = 0; x46 < 10; x46++)
// {
//   y46 = Convert.ToInt32(Math.Sqrt(R46 * R46 - x46 * x46));
//   Console.SetCursorPosition(x46, y46);

//   Console.Write("+");

// }

// 47. Написать программу копирования массива

int[] arr47 = CreateArray(10);
FillArray(arr47);
// метод 1
int[] arr47copy = arr47;
System.Console.WriteLine("");
System.Console.WriteLine("Задача 47");
PrintArray(arr47);
System.Console.WriteLine("");
PrintArray(arr47copy);
System.Console.WriteLine("");
PrintArray(CopyArray(arr47));

// метод 2
int[] CopyArray(int[] initarr)
{
  int[] res = new int[initarr.Length];
  for (int i = 0; i < initarr.Length; i++)
  {
    res[i] = initarr[i];
  }
  return res;
}

//Методы для обработки массивов

int[] CreateArray(int count)
{
  return new int[count];
}

void FillArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    array[i] = new Random().Next(0, 10);
  }
}

void FillArray2(int[] array, int minValue, int maxValue)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    array[i] = new Random().Next(minValue, maxValue);
  }
}
void FillArrayDouble(double[] array, int minValue, int maxValue)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    array[i] = new Random().NextDouble() * new Random().Next(minValue, maxValue);
  }
}
void PrintArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
}
void PrintArrayDouble(double[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
}

// string PrintArray2(int[] array)
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }

// int Sum(int[] array)
// {
//     int count = array.Length;
//     int sumP = 0;
//     for (int i = 0; i < count; i++)
//     {
//         if (array[i] > 0) sumP += array[i];
//     }
//     return sumP;
// }

// int[] arr = CreateArray(10);
// FillArray2(arr, 0, 3);
// Console.WriteLine(PrintArray2(arr));
// int s = Sum(arr);
// Console.WriteLine(s);



// (int x, int y) GetPoint2D()
// {
//   return (x: 10, y: 20);
// }

// (int pX, int pY) point = GetPoint2D();
// Console.WriteLine($"Координаты точки возвращает 2 параметра {point}");
// Console.WriteLine(point.pX);
// Console.WriteLine(point.pY);

