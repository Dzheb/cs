// Задача 11
//Разложите натуральное число n на простые множители и определите
//
// сколько раз встречается множитель 2 в произведении
// наименьший множитель произведения
// сколько различных множителей в произведении
// например число 36
int n = 36;
// Задаём массив простых чисел до 173
int[] simpleNumber = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173 };
int index = 0;
int count = 0;
Boolean minfound = false;
int minmult = 0;
int numult = 0;

while (n > 1)
{
  if (n % simpleNumber[index] == 0)

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
      count++;
    }
    Console.WriteLine(simpleNumber[index]);
    n = n / simpleNumber[index];
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
