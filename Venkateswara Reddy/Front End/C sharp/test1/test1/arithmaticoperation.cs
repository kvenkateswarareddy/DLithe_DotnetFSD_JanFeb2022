using System;

namespace Program2
{
    class Airthmatic
    {
        static void Main(String[] args)
        {
            Console.WriteLine("enter a and b values to perform arithmatic operations");
            int a= Convert.ToInt32(Console.ReadLine());
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Airthmatic Operations");
            Console.WriteLine("Addition: " + (a + b));
            Console.WriteLine("Substraction: " + (a - b));
            Console.WriteLine("Multiplication: " + (a * b));
            Console.WriteLine("Division: " + (a / b));
            Console.WriteLine("Modulus: " + (a % b));
        }
    }
}
