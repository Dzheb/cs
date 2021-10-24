using System;

namespace Example005_ConditionIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
            
        }
    }
}
