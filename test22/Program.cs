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
Console.Write("Введите строку содержащую операцию сложения : ");
instring = Console.ReadLine();

// определения операции по знаку
char sign = IsSign(instring);
int nsign = IndexOf(instring, sign);

// воспользукмся немножко готовым кодом (Int32)
// для определения првого и второго операндов
int numfirst = Int32.Parse(FindFirst(instring, nsign));
int numsecond = Int32.Parse(FindSecond(instring, nsign));
// Console.WriteLine(numfirst);
// Console.WriteLine(numsecond);


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

}
