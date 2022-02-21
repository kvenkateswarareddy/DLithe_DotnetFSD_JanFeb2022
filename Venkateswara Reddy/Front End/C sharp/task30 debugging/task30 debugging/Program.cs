namespace InterfaceDemo
{
interface  Iinterface1
{
public void Test();
    void Show();
}
interface Iinterface2
{
    void Test();
    void Show();
}
class ImplementInteraface : Iinterface1, Iinterface2
{
public void Test()
{
    Console.WriteLine(" Test method is implemented");
}
public void Show()
{
    Console.WriteLine(" Show method is implemented");
}
}
class Program
{
    static void Main(string[] args)
    {
        ImplementInteraface obj = new ImplementInteraface();
        obj.Test();
        obj.Show();
        Console.WriteLine( "Press any key to exit.");
        Console.ReadKey();
    }
}
}
