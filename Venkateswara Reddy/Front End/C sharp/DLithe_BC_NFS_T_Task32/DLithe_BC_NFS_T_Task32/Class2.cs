namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream F = new FileStream("text.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Console.WriteLine("Files Operations");
            Console.WriteLine();

            string writeText = "Hello venkatesh!, welcome to file operations.";  // Create a text string
            File.WriteAllText("textfile.txt", writeText);  // Create a file and write the contents to the textfile

            string readText = File.ReadAllText("textfile1.txt"); // Read the contents of the file
            Console.WriteLine(readText); // Output the content
        }
    }
}