using System;

namespace HeightWeightInfo
{
    class File1
    {
    }
    public partial class Record
    {
        private int h;
        private int w;
        public Record(int h, int w)
        {
            this.h = h;
            this.w = w;
        }
    }
    public partial class bike
    {
        public partial void InitializeCar();
        public void BuildRim() { }
        public void BuildWheels() { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Record myRecord = new Record(60, 20);
            myRecord.PrintRecord();
            bike c = new bike();
            c.InitializeCar();
            Console.ReadLine();
        }
    }
}
