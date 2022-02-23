class Program
{
    static void Main(string[] args)
    {
        var value = new SortedList<string, int>();            // sortedlist collection
        value.Add("java", 3);                                               // add element
        value.Add("javascript", 4);
        value.Add("c-sharp", 5);
        value.Add("dotnet", 25);
        value.Add("python", 27);
        value.Add("typescript", 57);
        foreach (var pair in value)
        {
            Console.WriteLine(pair);
            Console.ReadLine();
        }

        var val = new LinkedList<int>();             // linkedlist collection
        val.AddLast(13);          // add element
        val.AddLast(33);
        val.AddLast(23);
        val.AddLast(51);
        val.AddLast(60);
        val.AddFirst(4);
        val.AddFirst(6);
        LinkedListNode<int> node = val.Find(51);         // find the node
        val.AddBefore(node, 40);
        foreach (int num in val)
        {
            Console.WriteLine(num);
            Console.ReadLine();
        }

    }
}

