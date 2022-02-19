using System;

namespace Program2
{
    class TwoDArray
    {
        static void Main()
        {
            int[,] arr = {
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 } 
            };

            string[,] b = new string[,]
            {
                {"one", "two", "three", "four"},
                {"hai", "hello", "hru", "who"},
                {"venki", "vasu", "varun", "masthan"}
            };
            Console.WriteLine("Two Dimensional Array for integers");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j]+ "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Two Dimensional Array strings");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}