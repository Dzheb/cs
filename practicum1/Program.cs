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
