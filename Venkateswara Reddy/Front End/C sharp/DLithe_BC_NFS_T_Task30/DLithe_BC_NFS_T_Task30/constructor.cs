using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Difference
{
    class Demo
    {
        static int val1;
        int val2;

        static Demo()
        {
            Console.WriteLine("This is Static Constructor");
            val1 = 50;
        }

        public Demo(int val3)
        {
            Console.WriteLine("This is Instance Constructor");
            val2 = val3;
        }

        private void show()
        {
            Console.WriteLine("First Value = " + val1);
            Console.WriteLine("Second Value = " + val2);
        }

        static void Main(string[] args)
        {
            Demo d1 = new Demo(150);
            Demo d2 = new Demo(220);
            d1.show();
            d2.show();
            Console.ReadKey();
        }
    }
}
