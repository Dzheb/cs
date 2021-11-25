//Задача1
Console.WriteLine("Задача1");
//Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 
//Создать на его основе масив B, отбрасывая те, которые:
// - нарушают порядок возрастания
// - больше среднего арифметического элементов A
// - чётные
//
//
// Блок функций
//
//
// 1. функция получения случайного числа
int GetRandom(int minValue, int maxValue)
{

  return new Random().Next(minValue, maxValue);
}
// 2. функция заполнения массива
void FillArray(int[] collection, int minel, int maxel)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    collection[index] = GetRandom(minel, maxel);
    //Console.WriteLine(minel);
    // Console.WriteLine(maxel);
    index++;
  }
}

// 3. функция печати массива
void PrintArray(int[] col)
{
  int count = col.Length;
  int position = 0;
  while (position < count)
  {
    Console.Write(col[position] + "  ");
    position++;
  }
}
// 4. функция исключения элементов нарушения возрастания

int[] ExtractWrong(int[] collection)
{
  int length = collection.Length;
  int currentElement = collection[0];
  int index = 1;
  int indexc = 1;
  int[] coltrans = new int[10];
  coltrans[0] = currentElement;
  while (index < length - 1)
  {
    if (collection[index] > currentElement)
    {
      currentElement = collection[index];
      coltrans[indexc] = currentElement;
      indexc++;
    }

    index++;
  }
  return coltrans;
}

// 5. функция исключения элементов
//больше среднего арифметического элементов A

int[] ExtractBig(int[] collection, int mean)
{
  int length = collection.Length;
  int currentElement = collection[0];
  int index = 0;
  int indexc = 0;
  int[] coltrans = new int[10];
  coltrans[0] = currentElement;
  while (index < length)
  {
    if (collection[index] <= mean)
    {
      coltrans[indexc] = collection[index];
      indexc++;
    }

    index++;
  }
  return coltrans;
}

// 6. функция нахождения среднего арифметического эл-ов массива
int MeanArray(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  int sum = 0;

  while (index < length)
  {
    sum = sum + collection[index];
    index++;
  }

  int mean = sum / length;
  return mean;

}

// 7. функция исключения чётных элементов массива 

int[] ExtractEven(int[] collection)
{
  int length = collection.Length;
  int currentElement = collection[0];
  int index = 0;
  int indexc = 0;
  int[] coltrans = new int[10];
  coltrans[0] = currentElement;
  while (index < length)
  {

    if (collection[index] % 2 != 0)
    {
      coltrans[indexc] = collection[index];
      indexc++;
    }

    index++;
  }
  return coltrans;
}
// 8. функция исключения нулевых элементов массива 

int[] TruncZero(int[] collection)
{
  int length = collection.Length;
  int index = 0;
  while (index < length)
  {
    if (collection[index] == 0)
    {
      break;
    }
    index++;
  }
  int[] col = new int[index];
  length = col.Length;
  index = 0;
  while (index < length)
  {
    col[index] = collection[index];
    index++;
  }
  return col;
}
// 9. функция исключения элементов массива > 8

int[] ExtractMore(int[] collection, int lim)
{
  int length = collection.Length;
  //int currentElement = collection[0];
  int index = 0;
  int indexc = 0;
  int[] coltrans = new int[10];
  //coltrans[0] = currentElement;

  while (index < length)
  {
    //Console.WriteLine(collection[index]);
    //Console.WriteLine(lim);

    if (collection[index] <= lim)
    {
      coltrans[indexc] = collection[index];
      indexc++;
    }

    index++;
  }
  return coltrans;
}

// 10. функция знакочередования 

int[] SignOrder(int[] collection)
{
  int length = collection.Length;
  int[] coltrans = new int[10];
  //int currentElement = collection[0];
  int index = 0;
  int indexcol = 0;
  coltrans[indexcol] = collection[index];
  index++;
  // bool flagsign = true;

  //coltrans[0] = currentElement;
  while (index < length)
  {
    if (collection[index] > 0 && coltrans[indexcol] < 0)
    {
      // добавляем в новый массив если элемент с другим знаком
      indexcol++;
      coltrans[indexcol] = collection[index];
    }
    else
    {
      if (collection[index] < 0 && coltrans[indexcol] > 0)
      {
        indexcol++;
        coltrans[indexcol] = collection[index];
      }
    }

    index++;

  }
  return coltrans;
}

// Блок формирования и вывода результвта
//
// инициируем и заполняем начальный массив A
int[] arrayA = new int[10];

FillArray(arrayA, 5, 100);

// печатаем массив A
Console.Write("Исходный массив А:  ");
PrintArray(arrayA);
Console.WriteLine();

// Исключение элементов нарушения возрастания
// инициируем массив B
int[] arrayB1 = new int[10];
arrayB1 = TruncZero(ExtractWrong(arrayA));
// печатаем массив B
Console.Write("Массив без нарушения возрастания B:  ");
PrintArray(arrayB1);
Console.WriteLine();

// Исключение элементов 
// больше среднего арифметического элементов массива A
// инициируем массив B
int[] arrayB2 = new int[10];

arrayB2 = TruncZero(ExtractBig(arrayA, MeanArray(arrayA)));
// печатаем массив B
Console.Write("Массив элементов меньше среднего арифметического B:  ");
PrintArray(arrayB2);
Console.WriteLine();

// Исключение чётных элементов элементов массива A
// инициируем массив B
int[] arrayB3 = new int[10];

arrayB3 = TruncZero(ExtractEven(arrayA));
// печатаем массив B
Console.Write("Массив нечётных элементов элементов B:  ");
PrintArray(arrayB3);
Console.WriteLine();
// Конец Задачи1
//
//Задача2
Console.WriteLine("Задача2");
// Имеется числовой массив A заполненный числами из отрезка [minValue;maxValue]. Создать на его основе масив B, отбрасывая те, которые нарушают порядок
// - возрастания
// - элементы, больше 8
// - знакочередования
// Блок формирования и вывода результвта
//
// инициируем и заполняем начальный массив A
int[] arrayA2 = new int[10];

FillArray(arrayA2, 5, 99);

// печатаем массив A
Console.Write("Исходный массив А:  ");
PrintArray(arrayA2);
Console.WriteLine();

// Исключение элементов нарушения возрастания
// инициируем массив B
int[] arrayB21 = new int[10];
arrayB21 = TruncZero(ExtractWrong(arrayA2));
// печатаем массив B
Console.Write("Массив без нарушения возрастания B:  ");
PrintArray(arrayB21);
Console.WriteLine();

// Исключение элементов больших 8
// инициируем массив B
int[] arrayB22 = new int[10];
arrayB22 = TruncZero(ExtractMore(arrayA2, 8));
// печатаем массив B
Console.Write("Массив элементов меньших 8 B:  ");
PrintArray(arrayB22);
Console.WriteLine();

// формируем массив B со знакочередованием
// инициируем массив A и B
FillArray(arrayA2, -5, 10);
// печатаем массив A
Console.Write("Массив элементов A:  ");
PrintArray(arrayA2);
int[] arrayB32 = new int[10];

arrayB32 = TruncZero(SignOrder(arrayA2));
// печатаем массив B
Console.Write("Массив элементов со знакочередованием B:  ");
PrintArray(arrayB32);
Console.WriteLine();

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

//
// Задача 2
//
// Задать положительное вещественное число m. Cоставить целое число n из цифр
//
// десятков и сотых m
// единиц и сотых m
// сотен и десятых m

double m2 = 75874.4534;
System.Console.WriteLine("Задача 2 практикума :");
Console.WriteLine($"целое число n из десятков и сотых m : {ExtDecSot(m2)}");
Console.WriteLine($"целое число n из единиц и сотых m m : {ExtEdSot(m2)}");
Console.WriteLine($"целое число n из сотен и десятых m : {ExtSotDec(m2)}");



// десятков и сотых m
int ExtDecSot(double indouble)
{
  return ((int)m2 / 10 % 10) * 10 + (int)((m2 - (int)m2) * 100) % 10;
}
// единиц и сотых m
int ExtEdSot(double indouble)
{
  return ((int)m2 % 10) * 10 + (int)((m2 - (int)m2) * 100) % 10;
}
// сотен и десятых m
int ExtSotDec(double indouble)
{
  return ((int)m2 / 100 % 10) * 10 + (int)((m2 - (int)m2) * 10) % 10;
}


// Задача 3
// Написать программу, вычисляющую значение периодической функции f(x), в произвольной точке x, если на промежутке [a;b], который составляет один её период, значения функции вычисляются по формуле

// [-3; 3], f(x) = |x| - 1
// [-10; -2], f(x) = 1/x + 0.6
// [-4; 3], f(x) = Cos(|π*x|)

int x;
int y;
//Console.Clear();
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

// Задача 4
// Даны координаты концов двух отрезков [a; b], [c; d]. Верно ли, что

// отрезки не пересекаются
// отрезки пересекаются строго в одной точке
// один отрезок вложен в другой
// [a,b]
int xa4 = 1;
int ya4 = 5;
int xb4 = 7;
int yb4 = 20;
//
// [c,d]
int xc4 = 2;
int yc4 = 8;
int xd4 = 4;
int yd4 = 9;

int[,] ArrInt1 = FillInter(xa4, ya4, xb4, yb4);
int[,] ArrInt2 = FillInter(xc4, yc4, xd4, yd4);

Console.WriteLine("Задача 4 вектор линии 1");
if (ArrInt1.Length != 0) PrintArr2Dim(ArrInt1);
else Console.WriteLine("По заданным координатам невозможно построить отрезок");

Console.WriteLine("Задача 4 вектор линии 2");
if (ArrInt2.Length != 0) PrintArr2Dim(ArrInt2);
else Console.WriteLine("По заданным координатам невозможно построить отрезок");
// Ответ задачи
Console.WriteLine(IsRel(ArrInt1, ArrInt2));


string IsRel(int[,] curarr, int[,] targetarr)
{
  string res = string.Empty;
  int count = 0;
  int rows = curarr.GetUpperBound(0) + 1;    // количество строк
  int columns = curarr.Length / rows;  // количество столбцов

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns - 1; j++)
    {
      if (IsinTarget(curarr[i, j], curarr[i, j + 1], targetarr))
      {
        count = count + 1;
      }
    }
  }
  if (count == 0) res = "нет точек пересечения отрезков";
  if (count == 1) res = "отрезки пересекаются в одной точке";
  if (count > 1) res = "один отрезок принадлежит другому";

  return res;
}

bool IsinTarget(int x4, int y4, int[,] checkarr)
{
  bool res = false;
  int rows = checkarr.GetUpperBound(0) + 1;    // количество строк
  int columns = checkarr.Length / rows;  // количество столбцов

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns - 1; j++)
    {
      if (checkarr[i, j] == x4 && checkarr[i, j + 1] == y4)
      {
        res = true;
      }
    }
  }
  return res;
}

// получение всех точек отрезка
int[,] FillInter(int x1, int y1, int x2, int y2)
{
  int[,] res = new int[x2 - x1 + 1, 2];
  int rows = res.GetUpperBound(0) + 1;    // количество строк
  int columns = res.Length / rows;  // количество столбцов
  int curpoint = x1;// сохранение значения х первой точки
  // если координаты конечной точки по оси х меньше меняем местами значения х1 и х2
  if (x1 > x2)
  {
    x1 = x2;
    x2 = curpoint;
  }
  curpoint = x1;// сохранение значения х первой точки ещё раз

  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < columns; j++)
    {
      if (j % 2 == 0) res[i, j] = curpoint;
      else res[i, j] = (int)((double)(curpoint - xa4) / (xb4 - xa4) * (double)(yb4 - ya4) + ya4);
    }
    curpoint++;
  }
  return res;
}

void PrintArr2Dim(int[,] arr)
{
  int rows = arr.GetUpperBound(0) + 1;    // количество строк
  int columns = arr.Length / rows;        // количество столбцов

  for (int i = 0; i < rows; i++)
  {
    Console.Write($"Точка {i + 1}");
    for (int j = 0; j < columns; j++)
    {
      if (j % 2 == 0) Console.Write($"  x: {arr[i, j]}");
      else Console.Write($"  y: {arr[i, j]}");

    }
    Console.WriteLine("");
  }
}
// конец Задачи 4

// Задача 5
// Проверить, что натуральное число m
// является счастливым пятизначным
// образовано тремя цифрами, составляющими арифметическую прогрессию
// образовано четырмя одинаковыми цифрами
int m5 = 10575;
if (IsLucky(m5) && HowMany(m5) == 5)
{
  Console.WriteLine($"Число {m5} счастливое пятизначное");
}
else
{
  Console.WriteLine($"Число {m5} несчастливоене или непятизначное");
}
// проверка является ли число счастливым
bool IsLucky(int m5)
{
  bool res = false;
  // задаём количество циклов проверки 10000

  for (int i = 0; i < 10000; i++)
  {
    //Console.WriteLine($"Следующее число: {SumPow2(m5)}");
    m5 = SumPow2(m5);
    // если результат равен 1 выходим из цикла
    if (m5 == 1)
    {
      res = true;
      break;
    }
  }
  return res;
}

// нахождение суммы квадратов разрядов числа
int SumPow2(int sumelms)
{
  int res = 0;
  for (int i = 1; i <= HowMany(sumelms); i++)
  {
    res = res + Pow2(NumDec(sumelms, i));
  }
  return res;
}

// возведение в квадрат числа
int Pow2(int m5)
{
  return m5 * m5;
}
// определение количества разрядов в числе
int HowMany(int n27)
{
  int res = 1;
  while (n27 / Pow10(res) != 0)
  {
    res++;
  }
  return res;
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
// образовано тремя цифрами, составляющими арифметическую прогрессию
m5 = 777;

if (HowMany(m5) == 3 && IsProgr(m5))
{
  Console.WriteLine($"Число {m5} трёхзначное и с арифметической прогрессией");
}
// проверка на арифметическую прогрессию
bool IsProgr(int m5)
{
  if (NumDec(m5, 3) - NumDec(m5, 2) == NumDec(m5, 2) - NumDec(m5, 1)) return true;
  else return false;
}
// образовано четырьмя одинаковыми цифрами
m5 = 1111;

if (HowMany(m5) == 4 && IsEqual(m5))
{
  Console.WriteLine($"Число {m5} образовано четырьмя одинаковыми цифрами");
}
else
{
  Console.WriteLine($"Число {m5} образовано  не четырьмя одинаковыми цифрами");
}
// проверка на арифметическую прогрессию
bool IsEqual(int m5)
{
  if (NumDec(m5, 1) == NumDec(m5, 2) && NumDec(m5, 1) == NumDec(m5, 3) && NumDec(m5, 1) == NumDec(m5, 4)) return true;
  else return false;
}
// конец задачи 5

// Задача 6
// Выяснить является ли вещественное m
// целой степенью числа 3
// корнем целой степени из 5,
// синусом угла кратного 45 градусам
double m6 = 625.789;
int m6int = Convert.ToInt32(m6);
// задаём базу - число 3
int base3 = 3;
if (IsPwr3(m6, base3) && Convert.ToDouble(m6int) == m6)
  Console.WriteLine($"{m6} является целой степенью {base3}");
else Console.WriteLine($"{m6} не является целой степенью {base3}");
// метод проверки явяется ли м6 целой степенью 3
bool IsPwr3(double m6, int base3)
{
  bool res = false;
  int m6int = Convert.ToInt32(m6);
  int i = 0;
  int pwres = Convert.ToInt32(Math.Pow(base3, i));
  while (m6int > pwres)
  {
    i++;
    pwres = Convert.ToInt32(Math.Pow(base3, i));
  }
  if (m6int == pwres) res = true;
  return res;

}


// корнем целой степени из 5,
double mpwr5 = 5;
double mroot5 = Math.Sqrt(mpwr5);
if (IsRoot5(mpwr5, mroot5))
{

  Console.WriteLine($"{mroot5} является корнем {mpwr5}");
}

bool IsRoot5(double mpwr5, double mroot5)
{
  bool res = false;
  int i = 0;
  double pwres = Math.Pow(mroot5, i);
  while (Convert.ToInt32(mpwr5) >= pwres)
  {
    i++;
    pwres = Math.Pow(mroot5, i);
  }
  if (Math.Round(mpwr5) == Math.Round(pwres)) res = true;

  return res;
}
// синусом угла кратного 45 градусам
double anglesin = -0.7071067811865477;
if (Sin45(anglesin))
{
  Console.WriteLine($"{anglesin} является sin угла кратного 45 градусов");
}
else
{
  Console.WriteLine($"{anglesin} не является sin угла кратного 45 градусов");
}
// проверка является ли anglesin синусом угла кратного 45 градусам
bool Sin45(double anglesin)
{
  bool res = false;
  for (int i = 0; i < 8; i++)
  {
    Console.WriteLine($"Синус угла {anglesin}  {Math.Sin(Math.PI * i / 4)}");
    if (anglesin == Math.Sin(Math.PI * i / 4)) res = true;
  }
  return res;
}
// конец задачи 6




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
Writearr(arrxm, arrym, maxrow, maxcol);

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
void Writearr(int[] arrx, int[] arry, int maxrow, int maxcol)
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

// Задача 11
//Разложите натуральное число n на простые множители и определите
//
// сколько раз встречается множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении
// например число 36
int n11 = 36;
// Задаём массив простых чисел до 173
int[] simpleNumber = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173 };
int index = 0;
int count11 = 0;
Boolean minfound = false;
int minmult = 0;
int numult = 0;

while (n11 > 1)
{
  if (n11 % simpleNumber[index] == 0)

  {
    // если минимальный множитель ещё не найден присваиваем min первому
    if (!minfound)
    {
      minmult = simpleNumber[index];
      minfound = true;
    }
    // если множитель чётный увеличиваем счётчик
    if (simpleNumber[index] % 2 == 0)
    {
      count11++;
    }
    Console.WriteLine(simpleNumber[index]);
    n11 = n11 / simpleNumber[index];
    numult++;

  }
  else
  {
    index++;
  }

}

Console.WriteLine($"Сколько раз встречается множитель 2 в произведении :  {count}");
Console.Write("Минимальный множитель равен:  ");
Console.WriteLine(minmult);
Console.WriteLine($"Число простых множителей :  {numult}");



// Задача 22
// Ввести текст, содержащий числовое выражение заданного вида и найти его значение, например
// 21+34
// 
// 33/11
// 3^4

// функция определения есть ли + в строке
char IsSign(string? entstr)
{
  int length = entstr!.Length;
  int i = 0;
  char result = '@';
  while (i < length)
  {
    if (entstr[i] == '+' || entstr[i] == '/' || entstr[i] == '^')
    {
      result = entstr[i];
    }
    i++;
  }
  return result;
}

// функция определения номера знака в строке
int IndexOf(string? entstr, char sign)
{
  int length = entstr!.Length;
  int i = 0;
  int result = -1;
  while (i < length)
  {
    if (entstr[i] == sign)
    {
      result = i;
      break;
    }
    i++;
  }
  return result;
}

// функция определения первого элемента выражения
string FindFirst(string? entstr, int sign)
{
  int i = 0;
  string result = "";
  while (i < sign)
  {
    result = result + entstr![i];
    i++;
  }
  return result;
}

// функция определения второго элемента выражения
string FindSecond(string? entstr, int sign)
{
  int length = entstr!.Length;
  int i = sign + 1;
  string result = "";
  while (i < length)
  {
    result = result + entstr[i];
    i++;
  }
  return result;
}

// Основной блок
// 
// ввод строки
string? instring = "";
Console.Write("Введите строку содержащую операцию '+, / или ^'  : ");
instring = Console.ReadLine();
// проверка на пустую строку
if (instring == "")
{
  Console.Write("Вы ввели пустую строку");
}
else
{
  // проверка на знак операции
  if (IsSign(instring) == '@')
  {
    Console.WriteLine("Вы не ввели необходимый знак операции");
  }
  else

  {
    Console.WriteLine(IsSign(instring));
    // определение операции по знаку
    char sign = IsSign(instring);
    int nsign = IndexOf(instring, sign);
    // проверка на ввод операндов
    if (FindFirst(instring, nsign) == "" || FindSecond(instring, nsign) == "")
    {
      Console.WriteLine("Вы не ввели необходимые операторы/оператор");
    }
    else
    {

      // 
      // для определения первого и второго операндов воспользуемся немножко готовым кодом (Int32.Parse)
      int numfirst = Int32.Parse(FindFirst(instring, nsign));
      int numsecond = Int32.Parse(FindSecond(instring, nsign));
      //
      //Вывод результата
      switch (sign)
      {
        case '+':
          Console.WriteLine(numfirst + numsecond);
          break;
        case '/':
          Console.WriteLine(numfirst / numsecond);
          break;
        case '^':
          Console.WriteLine(Math.Pow(numfirst, numsecond));
          break;
        default:
          Console.WriteLine("Вы не ввели в строке оператор для расчёта");
          break;
      }
    }
  }
}


// Задача 7
// Даны четыре логические значения f1, f2, f3, f4. Записать условие того, что

// более трёх значений истинны
// хотя бы три значения истинны
// менее трёх значений истинны

bool f1 = true;
bool f2 = false;
bool f3 = false;
bool f4 = true;
Console.WriteLine("");
Console.WriteLine("Задача 7");
if (f1 && f2 && f3 && f4) Console.WriteLine("более трёх значений истинны");
if ((f1 && f2 && f3) || (f1 && f3 && f4) || (f2 && f3 && f4)) Console.WriteLine("хотя бы три значения истинны");
if (!((f1 && f2 && f3) || (f1 && f3 && f4) || (f2 && f3 && f4))) Console.WriteLine("менее трёх значений истинны");

// Задача 8
// Даны пять целых чисел. Выяснить, что

// три из них равны пяти
// больше трёх из них равны пяти
// менее трёх из них равны пяти

int num1 = 5;
int num2 = 5;
int num3 = 5;
int num4 = 4;
int num5 = 4;




if (((num1 == 5 || num2 == 5) && (num1 != num2)) && ((num3 == 5 || num4 == 5) && (num3 != num4)) && (num5 == 5)) Console.WriteLine("!!!");

