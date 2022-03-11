using System;

namespace Lar
{
    class Largestof3num
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter 3 numbers");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            int v1 = Convert.ToInt32(s1);
            int v2 = Convert.ToInt32(s2);
            int v3 = Convert.ToInt32(s3);
            if (v1 > v2)
            {
                if (v1 > v3)
                {
                    Console.WriteLine("Largest Number is: " + v1);
                }
                else
                {
                    Console.WriteLine("Largest: " + v3);
                }
            }
            else
            {
                if (v2 > v3)
                {
                    Console.WriteLine("Largest: " + v2);
                }
                else
                {
                    Console.WriteLine("Largest: " + v3);
                }
            }

        }
    }
}
