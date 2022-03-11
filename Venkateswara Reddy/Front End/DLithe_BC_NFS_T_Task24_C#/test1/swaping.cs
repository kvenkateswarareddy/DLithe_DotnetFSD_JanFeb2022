using System;
public class SwapExample
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter a and b values");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before swap a= " + a + " b= " + b);
        a = a * b; //a=50 (5*10)      
        b = a / b; //b=5 (50/10)      
        a = a / b; //a=10 (50/5)    
        Console.Write("After swap a= " + a + " b= " + b);
    }
}