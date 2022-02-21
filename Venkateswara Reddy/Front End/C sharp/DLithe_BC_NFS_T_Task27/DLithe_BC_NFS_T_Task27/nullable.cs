using System;

namespace CalculatorApplication
{
    class NullablesShow
    {
        static void Main(string[] args)
        {
            //Shorthand Syntax for Nullable Types
            int? num1 = null;
            int? num2 = 67;

            double? num3 = new double?();
            double? num4 = 5.468;

            bool? boolval = new bool?();

            // display the values
            Console.WriteLine("displaying nullable values");
            Console.WriteLine("Nullables at Show: {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("A Nullable boolean value: {0}", boolval);
            Console.ReadLine();
        }
    }
}
