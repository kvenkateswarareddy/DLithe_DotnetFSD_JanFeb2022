using System;
namespace AbstractDemo
{
    public abstract class Plan
    {
        protected double rate;
        public abstract void getRate();
        public void calculation(int units)
        {
            Console.Write("BILL AMOUNT FOR " + units + " UNITS is: Rs.");
            Console.WriteLine(rate * units);
        }
    }
    class CommercialPlan : Plan
    {
        public override void getRate()
        {
            rate = 8.00;
        }
    }
    class DomesticlPlan : Plan
    {
        public override void getRate()
        {
            rate = 3.50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("PREMIUM CONNECTION");
            p = new CommercialPlan();
            p.getRate();
            p.calculation(250);
            Console.WriteLine("BASIC CONNECTION");
            p = new DomesticlPlan();
            p.getRate();
            p.calculation(150);
            Console.ReadKey();
        }
    }
}
