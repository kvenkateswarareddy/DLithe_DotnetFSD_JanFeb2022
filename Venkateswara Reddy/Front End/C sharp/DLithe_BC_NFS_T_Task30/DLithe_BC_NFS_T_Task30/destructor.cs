﻿using System;
class HelloWorld {
  class First
{
    ~First()
    {
        System.Console.WriteLine("First's destructor is called");
    }
}
class Second : First
{
    ~Second()
    {
        System.Console.WriteLine("Second's destructor is called");
    }
}
class Third : Second
{
    ~Third()
    {
        System.Console.WriteLine("Third's destructor is called");
    }
}
class TestDestructors
{
    static void Main()
    {
        Third t = new Third();
    }
}
}
