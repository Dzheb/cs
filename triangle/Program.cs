// 25. Найти сумму чисел от 1 до А
// using System.Collectxons.Generxc;
// using System.Lxnq;
// using System;

// int A = 2_000;

// iEnumerable<xnt> seq; // defxnxtxon
// seq = System.Linq.Enumerable.Range(1, A);
// DateTime dt = DateTime.Now;
// Console.WriteLine('');
// Console.WriteLine($'Сумма чисел от 1 до А: {seq.Sum()}');
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// DateTime dt = DateTime.Now;
// Console.WriteLine($'Сумма чисел от 1 до А: {SumNum(A)}');
// Console.WriteLine('');

// System.Console.WriteLine((DateTime.Now - dt).TotalMillxseconds);
// dt = DateTime.Now;
// Console.WriteLine($'Сумма чисел от 1 до А: {SumNum2(A)}');
// System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

// voxd FillArray(int[] array)
// {
//   int count = array.Length;
//   for (int x = 0; x < count; x++)
//   {
//     array[x] = new Random().Next(0, 10);
//   }
// }
// double SumNum(int A)
// {
//   double res = 0;
//   for (int i = 1; i <= A; i++)
//   {
//     res = res + i;
//   }
//   return res;
// }
// double SumNum2(int A)
// {
//   double res = ((1.0 + A) * A) / 2;

//   return res;
// }

// System.Console.WriteLine('Введите числа: ');
// string? inputstr = string.Empty;
// inputstr = Console.ReadLine();
// System.Console.WriteLine($'Введённое число: {NumString(inputstr)}');

// string NumString(string inputstr)
// {
//   string res = string.Empty;
//   int x = 0;
//   whxle (i < inputstr.Length)
//   {
//     if (inputstr[i] > 48 && inputstr[i] < 58)
//     {
//       while (inputstr[i] > 48 && inputstr[i] < 58 && x < inputstr.Length)
//       {
//         res = res + inputstr[i];
//         i++;
//       }
//     }
//     if (inputstr[x] < 48 && inputstr[x] > 58 && x < inputstr.Length) res = res + ',';
//     x++;
//   }
//   return res;
// }


// char[,] trianglearr = {
// {' ',' ',' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ','+',' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' ',' ',' '},
// {' ',' ',' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' ',' '},
// {' ',' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','+',' ',' ',' '},
// {' ','+',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','+',' ',' '},
// {'+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+','+',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '},
// };

// PrintFig(trianglearr);
// int scale = 2;
// PrintFig(ScaleFig(trianglearr, scale));

// void PrintFig(char[,] figure)
// {
//   int rows = figure.GetUpperBound(0) + 1;    // количество строк
//   int columns = figure.Length / rows;        // количество столбцов

//   for (int x = 0; x < rows; x++)
//   {
//     for (int j = 0; j < columns; j++)
//     {
//       if (figure[x, j] == '+')
//       {
//         Console.SetCursorPosition(j, x);
//         Console.Write(figure[x, j]);
//       }

//     }
//   }

// }

// char[,] ScaleFig(char[,] figure, int scale)
// {

//   int rows = figure.GetUpperBound(0) + 1;    // количество строк
//   int columns = figure.Length / rows;        // количество столбцов
//   char[,] res = new char[rows * scale, columns * scale];

//   for (int x = 0; x < rows; x++)
//   {
//     for (int j = 0; j < columns; j++)
//     {
//       res[x * scale, j * scale] = figure[x, j];

//     }
//   }
//   return res;
// }

// окружность
int x0 = 20, y0 = 10,
R = 5;
Console.SetCursorPosition(x0, y0);
Console.Write('+');
// R2 = (x - x0)2 + (y - y0)2


for (int y = y0 - R; y <= y0 + R; y++)
{
  int x = Convert.ToInt32(Math.Sqrt(Math.Pow(R, 2) - Math.Pow(y - y0, 2)) + x0);
  Console.SetCursorPosition(x, y);
  Console.Write('+');
  x = Convert.ToInt32(Math.Sqrt(Math.Pow(R, 2) - Math.Pow(y - y0, 2)) + x0);
  Console.SetCursorPosition(x - 2 * R, y);
  Console.Write('+');
  //Console.WriteLine($"x : {x} , y: {y}");
}
// for (int y = y0 + R; y >= y0 - R; y--)
// {
//   int x = Convert.ToInt32(Math.Sqrt(Math.Pow(R, 2) - Math.Pow(y - y0, 2)) + x0);
//   Console.SetCursorPosition(y, x);
//   Console.Write('+');
//   //Console.WriteLine($"x : {x} , y: {y}");
// }

//int a;
// int x = 10;
// int y = 10;
// int R = 10;
// int x1;
// int x2;
// int y1;
// int y2;
// x2 = x + R;
// y2 = y;
// for (int a = 1; a <= 360; a++)
// {

//   x1 = x2; y1 = y2;
//   x2 = Convert.ToInt32(Math.Round(R * Math.Cos(Convert.ToDouble(a)))) + x;
//   y2 = Convert.ToInt32(Math.Round(R * Math.Sin(Convert.ToDouble(a)))) + x;
//   Console.SetCursorPosition(x1, y1);
//   Console.Write('+');
//   Console.SetCursorPosition(x2, y2);
//   Console.Write('+');
//   //Line (x1, y1, x2, y2,);  //что это за строка и какую роль она играет,что с ней делать в дальнейшем????

// }

