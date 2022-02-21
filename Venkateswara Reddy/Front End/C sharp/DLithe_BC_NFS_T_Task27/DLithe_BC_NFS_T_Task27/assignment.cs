using System;

public class Assignment
{
	public static void Main()
	{
		MyClass mycls = new MyClass();

		if (mycls.i == null)
			Console.WriteLine("Null");
	}
}

class MyClass
{
	public Nullable<int> i;
}