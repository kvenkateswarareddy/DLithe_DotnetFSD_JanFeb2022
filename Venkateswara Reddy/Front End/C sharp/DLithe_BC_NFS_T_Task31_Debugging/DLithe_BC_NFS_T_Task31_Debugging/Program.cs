namespace InterfaceDemo
{
    interface Iinterface1//added I
    {
        public void Test();//added void
        void Show();
    }
    interface Iinterface2//added I
    {
        void Test();
        void Show();
    }
    class ImplementInteraface : Iinterface1, Iinterface2// changed : to ,
    {
        public void Test()//deleted overide keyword and added void
        {
            Console.WriteLine(" Test method is implemented");//added ""
        }
        public void Show() ///deleted overide keyword and added void 
        {
            Console.WriteLine(" Show method is implemented");//added ""
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInteraface obj = new ImplementInteraface();
            obj.Test();
            obj.Show();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

