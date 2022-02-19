using System;
namespace application
{
    class Program
    {
        static void  Main(string[] args)// added void
        {
            int SNO, MARK1, MARK2, MARK3, AVERAGE;//added semicolon
            string SNAME;//added semicolon
            Console.WriteLine("ENTER THE STUDENT DETAILS");//l must be caps L
            Console.WriteLine("ENTER THE STUDENT NO");
            SNO = int.Parse(Console.ReadLine());//added ()
            Console.WriteLine("ENTER THE STUDENT NAME");
            SNAME = Console.ReadLine();
            Console.WriteLine("ENTER THE MARKS OF 3 SUBJECTS");
            MARK1 = int.Parse(Console.ReadLine());//changed mark2 to mark1
            MARK2 = int.Parse(Console.ReadLine());
            MARK3 = int.Parse(Console.ReadLine());
            int TOTAL = MARK1 + MARK2 + MARK3;//added semicolon and datatype int
            AVERAGE = TOTAL;
            Console.WriteLine("\n\n\nTHE STUDENT DETAILS ARE GIVEN BELOW :");// added semicolon
            Console.WriteLine("THE STUDENT NO IS: " + SNO);//added + symbol
            Console.WriteLine("THE STUUDENT NAME IS: " + SNAME);
            Console.WriteLine("TOTAL MARKS IS : " + TOTAL);
            Console.WriteLine("AVEARGE MAARK IS: " + AVERAGE);
            Console.ReadKey();
        }
    }
}
