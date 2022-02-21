using System;

namespace StringApplication
{

    class strings
    {

        static void Main(string[] args)
        {
            string s1 = "hello";//creating string using string keyword  
            String s2 = "welcome";//creating string using String class  

            string s3 = "hello";

            char[] ch = { 'c', 's', 'h', 'a', 'r', 'p' };
            string s4 = new string(ch);
            Console.WriteLine("calling keywords");
            Console.WriteLine("-------------------");
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine("");
            Console.WriteLine(" string Cancatination");
            Console.WriteLine("----------------------");
            //from string literal and string concatenation
            string fname, lname;
            fname = "venkateswara reddy";
            lname = "k";

            char[] letters = { 'w', 'e', 'l', 'c', 'o','m','e' };
            string[] arraystr = { "Hello", "this", "is",".Net", "Bootcamp" };

            string fullname = fname + lname;
            Console.WriteLine("Full Name: {0}", fullname);
            Console.WriteLine("");

            //by using string constructor { 'w', 'e', 'l', 'c', 'o','m','e' };
            string greetings = new string(letters);
            Console.WriteLine("Greetings: {0}", greetings);
            Console.WriteLine("");
            //methods returning string { "Hello", "this", "is",".Net", "Bootcamp" };
            string message = String.Join(" ", arraystr);
            Console.WriteLine("Message: {0}", message);
            Console.WriteLine("--------------------------------------");
            //formatting method to convert a value

            DateTime waiting = new DateTime(2018, 6, 4, 23, 51, 0);
            string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
            Console.WriteLine("Date and time format");
            Console.WriteLine("Message: {0}", chat);
            Console.WriteLine("-----------------------");
            Console.WriteLine("");

           Console.WriteLine("Two string are equal or not str1 = 'C#' and str2 = 'CSharp' ");
            string str1 = "C#";
            string str2 = "CSharp";

            if (String.Compare(str1, str2) == 0)
            {
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            Console.WriteLine("--------------------------------------");
            string str = "Welcome to C#";

            if (str.Contains("to"))
            {
                Console.WriteLine("The sequence 'to' was found.");
            }
            //finding the sub string
            Console.WriteLine("");
            Console.WriteLine("Finding the substring from the string");
            Console.WriteLine("");
            string str3 = "Hello Trainees";
            Console.WriteLine(str3);
            string substr = str3.Substring(6);
            Console.WriteLine(substr);
            Console.WriteLine("--------------------------------------");
            string[] starray = new string[]{"java",".net","C#",
            "ASP.Net",
            "SQL",
            "ADO.Net",
            "WPF"};

            Console.WriteLine("string array");
            Console.WriteLine("");
            string str4 = String.Join("\n", starray);
            Console.WriteLine(str4);
            Console.WriteLine("--------------------------------------");
            //The C# Clone() method is used to clone a string object. It returns another copy of same data. The return type of Clone() method is object.
            string s5 = "Hello world ";
            string s6 = (String)s1.Clone();
            Console.WriteLine("ClOning of string");
            Console.WriteLine("");
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine("--------------------------------------");
            //The C# CompareOrdinal() method compares two specified String objects by evaluating the numeric values of the corresponding Char objects in each string.

            // If both strings are equal, it returns 0.If first string is greater than second string, it returns positive number in difference else it returns negative number.
            string s11 = "hello";
            string s12 = "hello";
            string s13 = "csharp";
            string s14 = "mello";

            Console.WriteLine("");
            Console.WriteLine("co ordinal");
            Console.WriteLine("");
            Console.WriteLine(string.CompareOrdinal(s11, s12));
            Console.WriteLine(string.CompareOrdinal(s11, s13));
            Console.WriteLine(string.CompareOrdinal(s11, s14));
            Console.WriteLine("--------------------------------------");
            // The C# Concat() method is used to concatenate multiple string objects. 
            Console.WriteLine(string.Concat(s11, s12));
            Console.WriteLine("--------------------------------------");
            //The C# Copy() method is used to create a new instance of String with the same value as a specified String. It is a static method of String class. Its return type is string.
            string sc = string.Copy(s11);
            Console.WriteLine("Using COPY()");
            Console.WriteLine("");
            Console.WriteLine(s11);
            Console.WriteLine(sc);
            Console.WriteLine("--------------------------------------");
            //The C# CopyTo() method is used to copy a specified number of characters from the specified position in the string. It copies the characters of this string into a char array.
            string s15 = "Hello C#, How Are You?";
            char[] ch1 = new char[15];
            //public void CopyTo(int index, char[] ch, int start, int end)  
            s15.CopyTo(10, ch1, 0, 12);
            Console.WriteLine("using COPYTO(0,12) method");
            Console.WriteLine("");
            Console.WriteLine(ch1);
            Console.WriteLine("Using Endwith() ");
            Console.WriteLine("");
            //The C# EndsWith() method is used to check whether the specified string matches the end of this string or not. If the specified string is found at the end of this string, it returns true otherwise false.
            Console.WriteLine(s11.EndsWith("lo"));
            Console.WriteLine("--------------------------------------");
            //The C# Equals() method is used to check whether two specified String objects have the same value or not. If both strings have same value, it return true otherwise false.
            Console.WriteLine("using Euals");
            Console.WriteLine("");
            Console.WriteLine(s11.Equals(s12));
            Console.WriteLine("--------------------------------------");
            //The C# GetEnumerator() method is used to convert string object into char enumerator. It returns instance of CharEnumerator. So, you can iterate string through loop.
            string s16 = "Hello welome to .net";
            CharEnumerator ch2 = s16.GetEnumerator();
            while (ch2.MoveNext())
            {
                Console.WriteLine(ch2.Current);
            }

            Console.WriteLine("--------------------------------------");
            //The C# ToCharArray() method is used to get character array from a string object.
            char[] ch3 = s16.ToCharArray();
            foreach (char c in ch3)
            {
                Console.WriteLine(c);

            }

            Console.WriteLine("--------------------------------------");
            //The C# Split() method is used to split a string into substrings on the basis of characters in an array. It returns string array.
            string s17 = "Hello C Sharp";
            string[] s18 = s17.Split(' ');
            foreach (string s in s18)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("--------------------------------------");
            //The C# StartsWith() method is used to check whether the beginning of this string instance matches the specified string.
            bool b1 = s17.StartsWith("h");
            bool b2 = s17.StartsWith("H");
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine("--------------------------------------");

            //The C# Remove() method is used to get a new string after removing all the characters from specified beginIndex till given length. If length is not specified, it removes all the characters after beginIndex.
            string s19 = "Hello C#";
            string s20 = s1.Remove(2);
            Console.WriteLine(s20);
            Console.WriteLine("--------------------------------------");
            //The C# Replace() method is used to get a new string in which all occurrences of a specified Unicode character in this string are replaced with another specified Unicode character.
            string s21 = s19.Replace('C', 'F');
            Console.WriteLine(s21);
            Console.WriteLine("--------------------------------------");
            //Refer:https://www.javatpoint.com/csharp-string-replace
        }

    }
}
