// Задача 1
// Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые

// делятся на k, но на l
// делятся хотябы на k или на l
// не делятся на (k + l)

// задание n,k,l
int n = 20;
int k = 2;
int l = 3;
// количество чисел которые делятся на k, но не на l
int i = 1;
int count = 0;
while (i < n)
{
  if (i % k == 0 && i % l != 0)
  {
    count++;
    Console.WriteLine($"Число, которое делятся на {k} и не на {l}: {i}");

  }
  i++;
}
Console.WriteLine($"Кол-во чисел, которые делятся на {k} и не на {l}: { count}");

// делятся хотябы на k или на l
i = 1;
count = 0;
while (i < n)
{
  if (i % k == 0 || i % l == 0)
  {
    count++;
    Console.WriteLine($"Число, которое делятся на {k} или на {l}: {i}");

  }
  i++;
}
Console.WriteLine($"Кол-во чисел, которые делятся на {k} или на {l}: { count}");
// не делятся на (k + l)
i = 1;
int m = k + l;
count = 0;
while (i < n)
{
  if (i % m != 0)
  {
    count++;
    Console.WriteLine($"Число, которое не делятся на ({k} + {l}): {i}");

  }
  i++;
}
Console.WriteLine($"Кол-во чисел, которые не делятся на {k} + {l}: { count}");

// Задача 3
// Написать программу, вычисляющую значение периодической функции f(x), в произвольной точке x, если на промежутке [a;b], который составляет один её период, значения функции вычисляются по формуле

// [-3; 3], f(x) = |x| - 1
// [-10; -2], f(x) = 1/x + 0.6
// [-4; 3], f(x) = Cos(|π*x|)

int x;
int y;
Console.Clear();
// 1.
for (x = -3; x < 3; x++)
{
  y = Math.Abs(x) - 1;

  Console.WriteLine($"x = {x}  y = {y}");
}
// 2.
double ydouble = 0;
for (x = -10; x < -2; x++)
{
  if (x != 0)
  {
    ydouble = 1 / x + 0.6;
  }

  Console.WriteLine($"x = {x}  y = {ydouble}");
}

// 3.  [-4; 3], f(x) = Cos(|π*x|)
ydouble = 0;
for (x = -4; x <= 3; x++)
{

  ydouble = Math.Cos((Math.PI * x));

  Console.WriteLine($"x = {x}  y = {ydouble}");
}


// Задача 9 - решение в общем виде
// Проверить, что точка с координатами (x, y) принадлежит фигуре начало координат находится в верхнем левом углу
// 9.1
// размеры viewport 4*4
int maxcol = 4;
int maxrow = 4;
// принадлежит ли точка с координатами фигуре 1
// задание координат фигуры x и y двумя массивами
// фигура П
// int[] arrxm = { 0, 1, 2, 3, 4, 0, 4, 0, 4, 0, 4, 0, 4 };
// int[] arrym = { 0, 0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };
// фигура Q
// int[] arrxm = { 0, 1, 2, 3, 4, 0, 4, 0, 1, 2, 3, 4, 4 };
// int[] arrym = { 0, 0, 0, 0, 0, 1, 1, 2, 2, 2, 2, 2, 3 };
// фигура U
int[] arrxm = { 0, 4, 0, 4, 0, 4, 0, 1, 2, 3, 4 };
int[] arrym = { 0, 0, 1, 1, 2, 2, 3, 3, 3, 3, 3 };
// задание координат точки
int xa = 5;
int ya = 2;

// рисование фигуры
WriteFigure(arrxm, arrym, maxrow, maxcol);

// определение принадлежит ли точка данной фигуре
Console.WriteLine("");
if (MatchPoint(arrxm, arrym, maxrow, maxcol, xa, ya))
{
  Console.WriteLine($"Точка с координатами  x: {xa} и y: {ya} принадлежит этой фигуре");
}
else
{
  Console.WriteLine($"Точка с координатами  x: {xa} и y: {ya} не принадлежит этой фигуре");
}

//
//
// блок функций
// функция рисования фигуры
void WriteFigure(int[] arrx, int[] arry, int maxrow, int maxcol)
{
  i = 0;
  int j = 0;
  Console.Clear();
  int narr = 0;

  for (j = 0; j < maxrow; j++)
  {
    for (i = 0; i <= maxcol; i++)
    {
      for (narr = 0; narr < arrx.Length; narr++)
      {
        if (arrx[narr] == i && arry[narr] == j)
        {
          Console.SetCursorPosition(i, j);
          Console.Write("+");
          narr++;
        }
      }
    }
  }
}

// функция определения лежит ли точка на фигуре
Boolean MatchPoint(int[] arrx, int[] arry, int maxrow, int maxcol, int x, int y)
{
  i = 0;
  int j = 0;
  int narr = 0;
  Boolean match = false;

  for (j = 0; j < maxrow; j++)
  {
    for (i = 0; i <= maxcol; i++)
    {
      for (narr = 0; narr < arrx.Length; narr++)
      {

        if (x == i && y == j)
        {
          match = true;
          break;
        }
      }
    }
  }
  return match;
}



// // Задача 9 первоначальное решение
// // Проверить, что точка с координатами (x, y) принадлежит фигуре начало координат находится в верхнем левом углу
// // 9.1
// i = 0;
// int j = 0;
// int maxcol = 4;
// int maxrow = 4;
// // принадлежит ли точка с координатами фигуре 1
// // задание координат x и y двумя массивами
// int[] arrx = { 0, 1, 2, 3, 4, 0, 4, 0, 4, 0, 4, 0, 4 };
// int[] arry = { 0, 0, 0, 0, 0, 1, 1, 2, 2, 3, 3, 4, 4 };
// int xa = 4;
// int ya = 1;
// Boolean match = false;

// Console.Clear();
// for (j = 0; j < maxrow; j++)
// {
//   if (i == 0)
//   {
//     for (i = 0; i <= maxcol; i++)
//     {
//       Console.SetCursorPosition(i, j);
//       Console.Write("+");
//       if (xa == i && ya == j) match = true;

//     }
//   }
//   else
//   {
//     for (i = 0; i <= maxcol; i++)
//     {
//       if (i == 0 || i == maxcol)
//       {
//         if (xa == i && ya == j) match = true;
//         Console.SetCursorPosition(i, j);
//         Console.Write("+");
//       }

//     }
//   }

// }
// if (match)
// {
//   Console.WriteLine($"Точка с координатами  x: {xa} и y: {ya} принадлежит фигуре");
// }
// else
// {
//   Console.WriteLine($"Точка с координатами  x: {xa} и y: {ya} не принадлежит фигуре");
// }
