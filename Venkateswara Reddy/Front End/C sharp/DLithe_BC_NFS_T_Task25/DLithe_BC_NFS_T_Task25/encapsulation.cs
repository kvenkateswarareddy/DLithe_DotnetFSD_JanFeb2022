using System;

namespace Encapsulation
{
    class Emp
    {
        private string name; // field
        string email; //default private


        public string Name   // property
        {
            //private variables can only be accessed within the same class (an outside class has no access to it).
            //However, sometimes we need to access them - and it can be done with properties.

            //A property is like a combination of a variable and a method, and it has two methods: a get and a set method

            get { return name; }
            set { name = value; }

        }

        public Emp() //Constructor (no return type)
        {
            email = "kvenkateswara502@gmail.com";
            double phone = 9951619130;
            Console.WriteLine(email);
            Console.WriteLine(phone);
        }
        public Emp(out int a)
        {
            a = 341;


        }
    }

    class encapsulation
    {
        static void Main(string[] args)
        {
            Emp myObj = new Emp();
            Emp my2 = new Emp(out int x);
            myObj.Name = "venkatesh";
            // myObj.email = "abc@abc.com";
            Console.WriteLine(myObj.Name);

            Console.Write(x);
        }
    }
}