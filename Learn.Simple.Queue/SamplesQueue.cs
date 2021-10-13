using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SamplesQueue
    {
    public static void CreateQueue()
    {
        //Creates and initializes a new Queue.
        Queue myQ = new();
        myQ.Enqueue("Hello");
        myQ.Enqueue("World");
        myQ.Enqueue("!");

        //Displays the properties and values of the Queue.
        Console.WriteLine("myQ");
        Console.WriteLine($"\tCount:\t{myQ.Count}");
        Console.Write("\tValues:");
        PrintValues(myQ);
    }

    private static void PrintValues(IEnumerable myCollection)
    {
        foreach (Object obj in myCollection)
        {
            Console.Write($"\t{obj}");
        }
        Console.WriteLine();
    }
}

