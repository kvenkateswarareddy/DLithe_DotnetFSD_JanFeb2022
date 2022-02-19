using System;

namespace Program1
{
    class OneDArray
    {
        static void Main()
        {
            int[] a = { 6,7,8,9,10,15,18,20 };
            string[] b = { "sunday", "monday","tuesday","wednesday","thursday","friday","saturaday" };
            Console.WriteLine("1d array for numbers");
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\n1D  Array for strings");
            foreach (string j in b)
            {
                Console.WriteLine(j);
            }

        }
    }
}