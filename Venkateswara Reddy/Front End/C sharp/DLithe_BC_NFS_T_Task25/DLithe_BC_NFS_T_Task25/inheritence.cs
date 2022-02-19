﻿ using System;

namespace Inheritance //Single,multi-level,Hierarchical inheritance
{
     class Parent  // base class (parent) ,sealed class cannot be inherited
    {
        public string jobsforcompany= "Company";  
        public void feature()              
        {
            Console.WriteLine("Parent class:Company");
        }
    }

    class Fre : Parent // derived class (child)
    {
        public string str1= "freshers"; 
    }

    class Exp: Parent //Hierarchical inheritance
    {
        public string str2 = "experienced";
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a ob object
            Fre n1 = new Fre();
            Exp n2 = new Exp();

            // Call the feature() method (From the Parent class) on the ob object
            n1.feature();
            n2.feature();

            Console.WriteLine(n1.jobsforcompany + " " + n1.str1);
            Console.WriteLine(n2.jobsforcompany + " " + n2.str2);
        }
    }
}
