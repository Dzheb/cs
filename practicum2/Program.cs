// Комп загадал число в некотором диапазоне, например от 1 до 100. Далее он предлагает игроку угадать это число. Игрок вводит некоторое число и комп "отвечает":

// правильное ли это число или
// Загаданное число больше чем введенное
// загаданное число меньше чем введенное. После этого игрок делает следующую догадку. У Игрока есть некоторое количество попыток.
// Если игрок потратил все свои попытки, то игра заканчивается. Если игрок угадал число, но попытки еще остались, игра также заканчивается.

// Определить условия. (какой диапазон для загадывания чисел - мы его задаем, формируем рандомно или запрашиваем у пользователя?; определиться с количеством попыток - высчитать необходимое количество попыток, либо запросить у участника)
// Загадать число в указанном диапазоне.
// Начало игры - описываем правила.
// Запрашиваем у пользователя число. Пользователь вводит некоторое число (добавить проверку нештатных ситуаций). Определяем как оно соотносится с нашим загаданным и даем следующие инструкции игроку. Если пользователь не угадал, то у него сгорает 1 попытка.
// Игра продолжается пока есть попытки или пока пользователь не угадал число.
// int requestNumber() - метод запросит у игрока число, сделает все необходимые преобразования и вернет нам это число. int createNumber(int leftBound, int rightBound) - загадает число в указанном диапазоне и вернет его нам. bool MakeMove(int SecretNumber, int CountOfAttempts) - метод, в котором запрограммирован 1 игровой ход, в результате метод возвращает либо true, либо false. true если пользователь угадал число и игру надо остановить, false, если пользователь не угадал.

// int SecretNumber = createNumber(1, 100); int PlayersNumber = requestNumber();

int resGame = initGame();
System.Console.WriteLine(resGame);

int initGame()
{
  int attempts = 7;
  int leftBound = 1;
  int rightBound = 100;
  int SecretNumber = createNumber(leftBound, rightBound);
  System.Console.WriteLine($"Угадайте число от {leftBound} до {rightBound}  за {attempts} попыток");
  return playGame(SecretNumber, attempts);
}

int playGame(int numSec, int numAttempts)
{
  int attemptsMade = 0;
  int res = 0;// 0 - использовали все попытки и не выиграли 1 - угадали число
  do
  {
    attemptsMade++;
    numAttempts--;
    if (MakeMove(numSec, numAttempts))
    {
      System.Console.WriteLine($"Вы выиграли и угадали число: {numSec} за {attemptsMade} попыток!");
      res = 1;
      return res;
    }
    else System.Console.WriteLine($"Вы не угадали число у Вас осталось {numAttempts} попыток!");


  } while (numAttempts > 0);
  System.Console.WriteLine($"Вы проиграли и не угадали число: {numSec} за {attemptsMade} попыток!");
  return res;
}



int requestNumber() // метод запросит число 
{
  string inNumstr = string.Empty;
  do
  {
    System.Console.WriteLine("Введите число: ");
    inNumstr = ExError(Console.ReadLine());
  } while (inNumstr == "");
  return Convert.ToInt32(inNumstr);
}

string ExError(string? inputstring)
{
  string res = string.Empty;
  for (int i = 0; i < inputstring!.Length; i++)
  {
    if (inputstring[i] >= 48 && inputstring[i] < 58 || inputstring[i] == 45)
    {
      res = res + inputstring[i];
    }
  }
  return res;
}

// int createNumber = createNumber(1, 100);
int createNumber(int minValue, int maxValue)
{
  return new Random().Next(minValue, maxValue);
}

bool MakeMove(int SecretNumber, int CountOfAttempts)
{
  int reqNum = requestNumber();
  if (CountOfAttempts == 0) return false;

  if (SecretNumber == reqNum) return true;
  else
  {
    if (SecretNumber > reqNum)
    {
      System.Console.WriteLine($"Вы ввели {reqNum} , которое меньше загаданного числа");
      return false;
    }
    else
    {
      System.Console.WriteLine($"Вы ввели {reqNum} , которое больше загаданного числа");
      return false;
    }
  }
}