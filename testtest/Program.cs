
// See https://aka.ms/new-console-template for more information

int num = 56473;
int result = NumDec(num, 3);

Console.WriteLine($"3-я цифра 56473 : {NumDec(num, 3)}");

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

TestNumDec();
// тест метода TestNumDec()
void TestNumDec()
{
  int testnum = 4;
  if (NumDec(num, 3) == testnum) System.Console.WriteLine("Тест удался на славу");
  else System.Console.WriteLine("Тест провалился");

}

var u1 = new User("John Doe", "gardener");
var u2 = new User("Roger Roe", "driver");

Console.WriteLine(u1);
Console.WriteLine(u2);


class User
{
  private string Name;
  private string Occupation;

  public User(string Name, string Occupation) =>
      (this.Name, this.Occupation) = (Name, Occupation);

  public override string ToString() =>
      $"User {{ {this.Name} {this.Occupation} }}";
}

