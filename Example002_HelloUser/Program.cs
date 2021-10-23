using System;

namespace Example002_HelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ваше имя ");
            string username = Console.ReadLine();
            Console.Write("Привет, ");
            Console.Write(username);
            
        }
    }
}
