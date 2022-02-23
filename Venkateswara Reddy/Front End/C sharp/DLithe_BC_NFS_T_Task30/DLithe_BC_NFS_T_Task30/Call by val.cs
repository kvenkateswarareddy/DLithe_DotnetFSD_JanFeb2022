using System;

namespace Tutlane
{
    class Program
    {
        static void Square(int a, int b)
        {
            a = a * a;
            b = b * b;
            Console.WriteLine(a + " " + b);
        }
        static void Main(string[] args)
        {
            int num1 = 3;
            int num2 = 9;
            Console.WriteLine(num1 + " " + num2);
            Square(num1, num2);
            Console.WriteLine(num1 + " " + num2);
            Console.WriteLine("Press Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
