using System;
namespace GenericsDemo
{
    //Let us create a generic class with a generic constructor, generic member variable, generic property,
    //and a generic method as shown below.

    //MyGenericClass is a Generic Class
    class MyGenericClass<T>
    {
        //Generic variable
        //The data type is generic
        private T genericMemberVariable;
        //Generic Constructor
        //Constructor accepts one parameter of Generic type
        public MyGenericClass(T value)
        {
            genericMemberVariable = value;
        }
        //Generic Method
        //Method accepts one Generic type Parameter
        //Method return type also Generic
        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);
            return genericMemberVariable;
        }
        //Generic Property
        //The data type is generic
        public T genericProperty { get; set; }
    }
    class Program
    {
        static void Main()
        {
            MyGenericClass<int> integerGenericClass = new MyGenericClass<int>(60);
            int val = integerGenericClass.genericMethod(160);
            Console.WriteLine(val);
            MyGenericClass<string> stringGenericClass = new MyGenericClass<string>("hai venkatesh");
            string val1 = stringGenericClass.genericMethod("welcome to generics");
            Console.WriteLine(val1);
            Console.ReadKey();
        }
    }
}