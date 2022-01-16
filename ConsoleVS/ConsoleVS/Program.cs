using System;
using ListMaster;
namespace ConsoleVS
{
    class Progam
    {
        static public void Main(string[] args)
        {
            ArrayMaster am = new();
            for(int i = 0; i< 10; i++)
            {
                am.Add(new Random().Next(1, 3));
            }
         for(int i =0; i < am.GetCount(); i++)
            {

            Console.WriteLine(am.GetValue(i));
            }
            
        }
        
    }
}
