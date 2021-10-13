using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class GenericQueue
    {
    public static void Example()
    {
        Queue<string> numbers = new();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        //A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nDequeuing '{numbers.Dequeue()}'");
        Console.WriteLine($"Peek at next item to dequeue: {numbers.Peek()}");
        Console.WriteLine($"\nDequeuing '{numbers.Dequeue()}'");

        //Create a copy of the queue, using the ToArray method and the contructor that accepts an IEnumerable<T>.
        Queue<string> queueCopy = new(numbers.ToArray());
        Console.WriteLine("\nContents of the first copy");
        foreach (string number in queueCopy)
        {
            Console.WriteLine(number);
        }

        //Create an array twice the size of the queue and copy the elements of the queue, starting at the middle of the array
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        //Create a second queue, using the constructor that accepts an IEnumerable(of T).
        Queue<string> queueCopy2 = new(array2);
        Console.WriteLine("\nCOntents of the second copy, with duplicates and nulls:");
        foreach (var number in queueCopy2)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine($"\nqueueCopy.Contains('four')={queueCopy.Contains("four")}");
        Console.WriteLine("\nqueueCopy.clear()");
        queueCopy.Clear();
        Console.WriteLine($"\nqueueCopy.Count={queueCopy.Count}");
    }
    }

