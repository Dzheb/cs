
// Двумерные массивы
// Показать двумерный массив размером m×n заполненный целыми числами
// Показать двумерный массив размером m×n заполненный вещественными числами
// 50.В двумерном массиве n×k заменить четные элементы на противоположные
// 51. Задать двумерный массив следующим правилом: Aₘₙ = m+n
// 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
// 54. В матрице чисел найти сумму элементов главной диагонали
// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
// 56. Написать программу, которая обменивает элементы первой строки и последней строки
// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.
// 60. Составить частотный словарь элементов двумерного массива
// 60. Найти произведение двух матриц
// 61. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
// 62. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
// 63. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// 64. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
// Рекурсия
// 65. Показать натуральные числа от 1 до N, N задано
// 66. Показать натуральные числа от N до 1, N задано
// 67. Показать натуральные числа от M до N, N и M заданы
// 68. Найти сумму элементов от M до N, N и M заданы
// 69. Найти сумму цифр числа
// 70. Написать программу вычисления функции Аккермана
// 71. Написать программу возведения числа А в целую стень B
// 72. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
// 73. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

// 50.В двумерном массиве n×k заменить четные элементы на противоположные
int N = 7;
int K = 3;
int[,] array50 = (FillArray2dim(CreateArray2dim(N, K)));
PrintArray2dim(array50);
System.Console.WriteLine();
PrintArray2dim(IsEven(array50));

int[,] IsEven(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] % 2 == 0) array[i, j] *= -1;
    }
  }
  return array;
}


// 52. двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int m = 4;
int n = 5;
int[,] array52 = (FillArray2dim(CreateArray2dim(m, n)));
Console.WriteLine("Задача 52");
PrintArray2dim(array52);
Console.WriteLine("");
PrintArray2dim(SquareEven(array52));

int[,] SquareEven(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i += 2)
  {
    for (int j = 0; j < array.GetLength(1); j += 2)
    {
      array[i, j] = array[i, j] * array[i, j];
    }
  }
  return array;
}

// 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int m53 = 4;
int n53 = 5;
int[,] array53 = (FillArray2dim(CreateArray2dim(m53, n53)));
Console.WriteLine("Задача 52");
PrintArray2dim(array53);
Console.WriteLine();
Console.WriteLine("Введите целое число для поиска в массиве");
int findElement = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindElementInArray(array53, findElement));

(int m, int n) FindElementInArray(int[,] array, int findValue)
{
  int m = -1;
  int n = -1;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == findValue)
      {
        m = i;
        n = j;
        break;
      }
    }
    if (m != -1 && n != -1) break;
  }
  return (m, n);
}


// 54. В матрице чисел найти сумму элементов главной диагонали

int m54 = 5;
int n54 = 5;
int[,] array54 = (FillArray2dim(CreateArray2dim(m54, n54)));
Console.WriteLine("Задача 54");
PrintArray2dim(array54);
Console.WriteLine($"Сумма элементов главной диагонали: {Sum(array54)}");


int Sum(int[,] array)
{
  int sum = 0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (i == j) sum = sum + array[i, j];
    }
  }
  return sum;
}

// 55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] array55int = (FillArray2dim(CreateArray2dim(4, 4)));
double[] arr55 = Average(array55int);
PrintArray2dim(array55int);
System.Console.WriteLine();
PrintArr2DimDouble(arr55);

double[] Average(int[,] array)
{
  double[] average = new double[array.GetLength(0)];
  for (int j = 0; j < array.GetLength(0); j++)
  {

    int sum = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
      sum = sum + array[i, j];
    }

    average[j] = (double)sum / array.GetLength(0);
  }
  return average;
}


// 56. Написать программу, которая обменивает элементы первой строки и последней строки
char[,] array56 = (FillArray2DimChar(CreateArray2DimChar(4, 4)));
Console.WriteLine("Задача 56");
PrintArr2DimChar(array56);
Console.WriteLine();
PrintArr2DimChar(ChangeStringsInArray(array56, 0, array56.GetLength(0)));

char[,] ChangeStringsInArray(char[,] array, int firstString, int lastString)
{

  char temp;
  for (int j = 0; j < array.GetLength(0); j++)
  {
    temp = array[firstString, j];
    array[firstString, j] = array[lastString - 1, j];
    array[lastString - 1, j] = temp;
  }
  return array;
}


// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

Console.WriteLine("Задача 57");
int[,] array57 = (FillArray2dim(CreateArray2dim(3, 3)));
PrintArray2dim(array57);
Console.WriteLine("Сверху оригинальный массив снизу сортированный");
PrintArray2dim(SelectTwoDimentArray(array57));


int[] Select(int[] array)
{
  int temp;
  int length = array.Length;
  for (int i = 0; i < length; i++)
  {
    for (int j = 0; j < length - 1; j++)
    {
      if (array[j] < array[j + 1])
      {
        temp = array[j];
        array[j] = array[j + 1];
        array[j + 1] = temp;
      }
    }
  }
  return array;
}

int[,] SelectTwoDimentArray(int[,] array)
{
  int[] line = new int[array.GetLength(1)];
  int[] sortLine = new int[array.GetLength(1)];
  for (int i = 0; i < array.GetLength(0); i++)
  {

    for (int j = 0; j < array.GetLength(1); j++)
    {
      line[j] = array[i, j];

    }
    sortLine = Select(line);
    for (int k = 0; k < array.GetLength(1); k++)
    {
      array[i, k] = sortLine[k];
    }
  }
  return array;
}


// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
int[,] array58 = FillArray2dim(CreateArray2dim(5, 5));
PrintArray2dim(array58);
Console.WriteLine("Задача 58");
PrintArray2dim(Transposition(array58));

bool NotSquareMatrix(int[,] array)
{
  return array.GetLength(0) == array.GetLength(1);
}

int[,] Transposition(int[,] array)
{
  int[,] transposedArray = new int[array.GetLength(0), array.GetLength(1)];
  bool squareMatrix = NotSquareMatrix(array);
  for (int i = 0; i < array.GetLength(0); i++)
  {
    if (squareMatrix)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        transposedArray[j, i] = array[i, j];
      }
    }
    else
    {
      System.Console.WriteLine("Транспонирование невозможно");
      break;
    }
  }
  return transposedArray;
}

// 60. Составить частотный словарь элементов двумерного массива

// string little = "Так как я никогда в жизни не рисовал баранов"
System.Console.WriteLine("Задача 60");
string little = "Так так ТАК как я никогда в жизни не рисовал баранов".ToLower()
                + " я я я я я повторил для него одну из двух старых картинок"
                + " которые я               только и умею рисовать удава снаружи".ToLower();

var littleArray = little.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
Dictionary<string, int> doc = new();
for (int i = 0; i < littleArray.Length; i++)
{
  if (!doc.ContainsKey(littleArray[i])) doc.Add(littleArray[i], 1);
  else doc[littleArray[i]]++;
}
System.Console.WriteLine(doc["я"]);
foreach (var item in doc)
{
  System.Console.WriteLine(item.Value);
}
// void PrintArrayNew(string[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]}  ");

//62. Сформировать трехмерный массив не повторяющимися двузначными числами 
// показать его построчно на экран выводя индексы соответствующего элемента

int str62 = 4;

int[,,] NewArray3dim(int a)
{
  int[,,] array = new int[a, a, a];
  return array;
}

int[,,] FillArray3dim(int[,,] array)
{
  int num = 10;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(2); k++)
      {
        array[i, j, k] = num++;
      }
  return array;
}

void PrintArray3dim(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.WriteLine($"{array[i, j, k]} ({i}, {j}, {k})");
      }
}

int[,,] Array62 = NewArray3dim(str62);
FillArray3dim(Array62);
PrintArray3dim(Array62);

// 61. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int str61 = 6;
int coll61 = 10;

int[,] NewArray61(int a, int b)
{
  int[,] array = new int[a, b];
  return array;
}

int[,] FillArray61(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 1000);
    }
  return array;
}

void PrintArray61(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}  ");
    }
    Console.WriteLine();
  }
}

(int minStr, int minCol, int minValue) FindMin(int[,] array)
{
  int minValue = array[0, 0];
  int minStr = 0;
  int minCol = 0;
  for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < minValue)
      {
        minValue = array[i, j];
        minStr = i;
        minCol = j;
      }
    }
  return (minStr, minCol, minValue);
}

int[,] ReWrite(int[,] array, int a, int b)
{
  int[,] newArray = new int[(array.GetLength(0) - 1), (array.GetLength(1) - 1)];
  int l = 0;
  int k = 0;
  for (int i = 0; i < newArray.GetLength(0); i++)
  {
    if (k == a && (k < array.GetLength(0) - 1)) k++;
    for (int j = 0; j < newArray.GetLength(1); j++)
    {
      if (l == b && (l < array.GetLength(1) - 1)) l++;
      newArray[i, j] = array[k, l];
      if (l < (array.GetLength(1) - 1)) l++;
    }
    if (k < array.GetLength(0) - 1) k++;
    l = 0;
  }
  return newArray;
}

int[,] MyArray61 = NewArray61(str61, coll61);
int[] Summ61 = new int[MyArray61.GetLength(0)];
FillArray61(MyArray61);
PrintArray61(MyArray61);
Console.WriteLine();
(int minStr, int minCol, int minValue) result = FindMin(MyArray61);
Console.WriteLine(result.Item3);

PrintArray61(ReWrite(MyArray61, result.minStr, result.minCol));

// 63. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

Console.WriteLine("Введите нужное количество строк треугольника Паскаля:");

int line = Convert.ToInt32(Console.ReadLine());

int Factorial(int n)

{
  int x = 1;
  for (int i = 1; i <= n; i++)
  {
    x *= i;
  }
  return x;
}

for (int i = 0; i < line; i++)
{
  for (int c = 0; c <= (line - i); c++)
  {
    Console.Write("-");
  }
  for (int c = 0; c <= i; c++)
  {
    Console.Write("-");
    Console.Write(Factorial(i) / (Factorial(c) * Factorial(i - c)));
  }
  Console.WriteLine();
  Console.WriteLine();
}

// 64. Спирально заполнить двумерный массив:
//   1  2  3  4
//  12 13 14  5
//  11 16 15  6
//  10  9  8  7 
//Заполним массив, количество строк мы обозначим m, а столбцов - n.

//Объявляем и инициализируем массив.
int[,] array64 = new int[5, 5];
int lastcell;

(array64, lastcell) = ArrFillPerimetr(array64, array64.GetLength(0), array64.GetLength(1));
(array64, lastcell) = ArrFillCore(array64, array64.GetLength(0), array64.GetLength(1), lastcell);
array64 = FillLastCell(array64, lastcell);
Console.WriteLine();
// печать массива 
PrintArray2dim(array64);

//Заполняем периметр массива по часовой стрелке.
//
(int[,] outarr, int outnum) ArrFillPerimetr(int[,] array, int row, int col)


{
  //С помощью переменной s задаются числа внутри массива начиная с 1.
  // int num = 1;
  int num = 1;
  for (int i = 0; i < col; i++)
  {
    array[0, i] = num;
    num++;
  }
  for (int i = 1; i < row; i++)
  {
    array[i, row - 1] = num;
    num++;
  }
  for (int j = col - 2; j >= 0; j--)
  {
    array[row - 1, j] = num;
    num++;
  }
  for (int i = row - 2; i > 0; i--)
  {
    array[i, 0] = num;
    num++;
  }
  return (array, num);

}

//Периметр заполнен. Продолжаем заполнять массив и задаём
//координаты ячейки, которую необходимо заполнить следующей.
(int[,] outarr, int outnum) ArrFillCore(int[,] array, int row, int col, int num)
{

  int xStart = 1;
  int yStart = 1;

  while (num < row * col)
  {
    //Периметр мы заполнили числами, отличными от нулей.
    //Следующие циклы поочерёдно работают, заполняя ячейки.
    //Вложенный цикл останавливается, если следующая ячейка имеет 
    //значение, отличное от ноля. Ячейка, на которой остановился 
    //цикл, не заполняется.

    //Движемся вправо.
    while (array[xStart, yStart + 1] == 0)
    {
      array[xStart, yStart] = num;
      num++;
      yStart++;
    }

    //Движемся вниз.
    while (array[xStart + 1, yStart] == 0)
    {
      array[xStart, yStart] = num;
      num++;
      xStart++;
    }

    //Движемся влево.
    while (array[xStart, yStart - 1] == 0)
    {
      array[xStart, yStart] = num;
      num++;
      yStart--;
    }

    //Движемся вверх.
    while (array[xStart - 1, yStart] == 0)
    {
      array[xStart, yStart] = num;
      num++;
      xStart--;
    }
  }
  return (outarr: array, outnum: num);
}
//При данном решении в центре всегда остаётся незаполненная ячейка.
//Убираем её при помощи следующего цикла.
int[,] FillLastCell(int[,] array, int num)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] == 0)
      {
        array[i, j] = num;
      }
    }
  }
  return array;
}
Console.WriteLine();

// //Выводим массив в консоль.
// PrintArray2dim(array);

// 65. Показать натуральные числа от 1 до N, N задано
string PrintNumbers1N(int n)
{
  if (n == 1) return "1";
  else return $"{PrintNumbers1N(n - 1)} " + $"{n}";

}
Console.WriteLine(PrintNumbers1N(10));

// 66. Показать натуральные числа от N до 1, N задано
string PrintNumbers(int n)
{
  if (n == 1) return "1";
  else return $"{n} " + $"{PrintNumbers(n - 1)}";

}
Console.WriteLine(PrintNumbers(10));

// 67. Показать натуральные числа от M до N, N и M заданы
string PrintNumbersMN(int M, int N)
{

  if (M == N) return $"{N} ";
  if (M > N) return $"{M} " + $"{PrintNumbersMN(M - 1, N)}";
  else return $"{PrintNumbersMN(M - 1, N)} " + $"{M} ";

}
Console.WriteLine(PrintNumbersMN(40, 30));



// 68. Найти сумму элементов от M до N, N и M заданы

int PrintNumbersSumMN(int M, int N)
{

  if (M == N) return N;
  if (M > N) return M + PrintNumbersSumMN(M - 1, N);
  else return PrintNumbersSumMN(M + 1, N) + M;

}
Console.WriteLine(PrintNumbersSumMN(1, 3));

// 69. Найти сумму цифр числа

int tempor = 0;

int Summ(int num, int div, int temp)
{
  if (num / div == 0) return temp;
  temp += (num / div) % 10;
  return Summ(num, div * 10, temp);
}

Console.WriteLine(Summ(232, 1, tempor));

// 70. Написать программу вычисления функции Аккермана
//             if m > 0  n = 0      a(m-1,1)
//             if m> 0, n > 0       A(m-1, A(m, n -1)) 


int Akkerman(int m, int n)
{
  if (m == 0) return (n + 1);
  if (m > 0 && n == 0) return Akkerman(m - 1, 1);
  if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
  return Akkerman(m, n);
}

Console.WriteLine(Akkerman(2, 4));

// 71. Написать программу возведения числа А в целую стень B
int Degree(int a, int b)
{
  if (b == 0) return 1;
  else if (b % 2 == 0) return Degree(a * a, b / 2);
  else return Degree(a, b - 1) * a;
}

Console.WriteLine("Введите основание степени");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите показатель степени");
int B = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Degree(A, B));

///////////////
// 72. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем

string SumOfNumbers(int number1, int number2, int n)
{
  if (n == 1) return $"{number1}";
  else return $"{number1}, {SumOfNumbers(number2, number2 + number1, n - 1)}";
}
Console.WriteLine("Задача 72");
System.Console.WriteLine(SumOfNumbers(3, 4, 10));

// 73. В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита

int nn = 1;
void Findwords(string alphabet, char[] word, int length = 0)
{
  if (length == word.Length)
  {
    Console.WriteLine($"{nn++} {new String(word)}"); return;
  }
  for (int i = 0; i < alphabet.Length; i++)
  {
    word[length] = alphabet[i];
    Findwords(alphabet, word, length + 1);
  }
}
Findwords("аисв", new char[2]);


//
//
//Методы для обработки массивов
//
//

// создание  массива
// int[] CreateArray(int i)
// {
//   return new int[i];
// }


// создание ддвумерного массива
int[,] CreateArray2dim(int i, int j)
{
  return new int[i, j];
}

char[,] CreateArray2DimChar(int i, int j)
{
  return new char[i, j];
}

// заполнение двумерного массива
int[,] FillArray2dim(int[,] array)
{

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0, 10);
    }

  }
  return array;
}

char[,] FillArray2DimChar(char[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = (char)(new Random().Next(65, 90));
    }

  }
  return arr;
}

// void FillArray2(int[] array, int minValue, int maxValue)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     array[i] = new Random().Next(minValue, maxValue);
//   }
// }

// void FillArrayDouble(double[] array, int minValue, int maxValue)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     array[i] = new Random().NextDouble() * new Random().Next(minValue, maxValue);
//   }
// }

// void PrintArray(int[] array)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
// }
// void PrintArrayDouble(double[] array)
// {
//   int count = array.Length;
//   for (int i = 0; i < count; i++)
//   {
//     Console.Write($"{array[i]} ");
//   }
// }

void PrintArr2DimDouble(double[] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {

    System.Console.Write($"{array[i]} ");

  }
}

// string Print Array2dim2(int[] array)
// {
//     int count = array.Length;
//     string res = String.Empty;
//     for (int i = 0; i < count; i++)
//     {
//         res += $"{array[i]} ";
//     }
//     return res;
// }

//печать двумерного массива

void PrintArray2dim(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i, j] < 10)
      {
        //Два пробела, чтобы в консоли столбцы были ровные.
        Console.Write(array[i, j] + ",  ");
      }
      else
      {
        Console.Write(array[i, j] + ", ");
      }
    }
    Console.WriteLine();
  }
}

void PrintArr2DimChar(char[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write($"{array[i, j]} ");
    }
    System.Console.WriteLine();
  }
}


// генерация строки
// System.Console.WriteLine(Guid.NewGuid().ToString().Substring(6, 6));

// https://github.com/MrFedko/task-seminar.git


