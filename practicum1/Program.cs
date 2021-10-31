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
  
  return new Random().Next(minValue,maxValue);
}
// 2. функция заполнения массива
void FillArray(int[] collection, int minel, int maxel)
{
    int length = collection.Length;
    int index = 0;
     while (index < length)
     {
         collection[index] = GetRandom(minel,maxel);
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
        Console.Write(col[position] +"  ");
        position++;
    }
}
// 4. функция исключения элементов нарушения возрастания

int[]  ExtractWrong(int[] collection)
{
    int length = collection.Length;
    int currentElement = collection[0];
    int index = 1;
    int indexc = 1;
    int[] coltrans = new int[10];
    coltrans[0] = currentElement;
     while (index < length-1)
     {
       if(collection[index] > currentElement)
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

int[]  ExtractBig(int[] collection, int mean)
{
    int length = collection.Length;
    int currentElement = collection[0];
    int index = 0;
    int indexc = 0;
    int[] coltrans = new int[10];
    coltrans[0] = currentElement;
     while (index < length)
     {
       if(collection[index] <= mean)
        {
          coltrans[indexc] = collection[index];
          indexc++; 
        }
         
         index++; 
     }
     return coltrans;
}

// 6. функция нахождения среднего арифметического эл-ов массива
int  MeanArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    int sum = 0;

    while (index < length)
      {
          sum = sum + collection[index];
          index++;
      }

      int mean = sum/length;
      return mean;

    }

// 7. функция исключения чётных элементов массива 

int[]  ExtractEven(int[] collection)
{
    int length = collection.Length;
    int currentElement = collection[0];
    int index = 0;
    int indexc = 0;
    int[] coltrans = new int[10];
    coltrans[0] = currentElement;
     while (index < length)
     {

       if(collection[index] % 2 != 0)
        {
          coltrans[indexc] = collection[index];
          indexc++; 
        }
         
         index++; 
     }
     return coltrans;
}
// 8. функция исключения нулевых элементов массива 

int[]  TruncZero(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
     {
       if(collection[index] == 0)
        {
          break; 
        }
        index++; 
     }
    int [] col = new int[index];
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

int[]  ExtractMore(int[] collection, int lim)
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
        
       if(collection[index] <= lim )
        {
          coltrans[indexc] = collection[index];
          indexc++; 
        }
         
         index++; 
     }
     return coltrans;
}

// 10. функция знакочередования 

int[]  SignOrder(int[] collection)
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
        if(collection[index] > 0 && coltrans[indexcol] < 0)
        { 
          // добавляем в новый массив если элемент с другим знаком
          indexcol++;
          coltrans[indexcol] = collection[index];
        } else
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

FillArray(arrayA,5,100);

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

FillArray(arrayA2,5,99);

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
FillArray(arrayA2,-5,10);
// печатаем массив A
Console.Write("Массив элементов A:  ");
PrintArray(arrayA2);
int[] arrayB32 = new int[10];

arrayB32 = TruncZero(SignOrder(arrayA2));
// печатаем массив B
Console.Write("Массив элементов со знакочередованием B:  ");
PrintArray(arrayB32);
Console.WriteLine();



