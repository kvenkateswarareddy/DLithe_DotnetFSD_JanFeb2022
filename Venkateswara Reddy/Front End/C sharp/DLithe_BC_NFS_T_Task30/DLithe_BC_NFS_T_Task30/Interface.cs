using System;

namespace Interface
{
    //An interface is a completely "abstract class", which can only contain abstract methods and properties (with empty bodies)
    interface IFirstInterface
    {
        string Name { get; set; }
        void myMethod(); // interface method
    }

    interface ISecondInterface
    {
        void myOtherMethod(); // interface method
    }
    interface IThirdInterface
    {
        void myOtherMethod1(); // interface method
    }

    // Implement multiple interfaces
    class DemoClass : IFirstInterface, ISecondInterface, IThirdInterface
    {
        public string Name
        {
            get;
            set;
        }
        public void myMethod()
        {
            Console.WriteLine("First interface1 created");

        }
        public void myOtherMethod()
        {
            Console.WriteLine("Second Interface2  created");
        }
        public void myOtherMethod1()
        {
            Console.WriteLine("Third Interface3 created");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass myObj = new DemoClass();
            myObj.Name = "Venkateswara Reddy";
            myObj.myMethod();
            myObj.myOtherMethod();
            myObj.myOtherMethod1();
            Console.WriteLine(myObj.Name);
        }
    }
}
