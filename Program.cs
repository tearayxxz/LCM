using System;
namespace LMC
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("please input a: ");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.Write("please input b: ");
            b = int.Parse(Console.ReadLine());
            int x = a, y = b;
            do
            {
                if (x < y)
                {
                    x = x + a;
                }
                else
                {
                    y = y + b;
                }
            } while (x != y);
            Console.WriteLine("The answer of {0} and {1} is{2}", a, b, x);
            Console.Read();
        }
    }
}