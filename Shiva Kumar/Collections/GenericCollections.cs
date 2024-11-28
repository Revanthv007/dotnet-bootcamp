Generic Collections (List, Dictionary, Stack, and Queue) in C#

Program 1: List<T>
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Initial List:");
        PrintList(numbers);

        numbers.Add(6);
        numbers.AddRange(new List<int> { 7, 8 });

        Console.WriteLine("\nAfter adding elements:");
        PrintList(numbers);

        numbers.Insert(2, 10);
        Console.WriteLine("\nAfter inserting 10 at index 2:");
        PrintList(numbers);

        numbers.Remove(4);
        Console.WriteLine("\nAfter removing element 4:");
        PrintList(numbers);

        numbers.RemoveAt(3);
        Console.WriteLine("\nAfter removing element at index 3:");
        PrintList(numbers);

        Console.WriteLine($"\nList contains 10: {numbers.Contains(10)}");

        numbers.Sort();
        Console.WriteLine("\nAfter sorting:");
        PrintList(numbers);

        Console.WriteLine("\nFinding index of 7:");
        Console.WriteLine($"Index: {numbers.IndexOf(7)}");

        numbers.Clear();
        Console.WriteLine("\nAfter clearing the list:");
        PrintList(numbers);
    }

    static void PrintList(List<int> list)
    {
        Console.WriteLine(string.Join(", ", list));
    }
}

Program 2: Dictionary<TKey, TValue>
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

        Console.WriteLine("Initial Dictionary:");
        PrintDictionary(dictionary);

        dictionary["David"] = 40;
        dictionary["Alice"] = 28;

        Console.WriteLine("\nAfter adding and updating elements:");
        PrintDictionary(dictionary);

        dictionary.Remove("Bob");
        Console.WriteLine("\nAfter removing key 'Bob':");
        PrintDictionary(dictionary);

        Console.WriteLine("\nKeys:");
        foreach (var key in dictionary.Keys)
            Console.WriteLine(key);

        Console.WriteLine("\nValues:");
        foreach (var value in dictionary.Values)
            Console.WriteLine(value);

        Console.WriteLine("\nContains key 'Charlie': " + dictionary.ContainsKey("Charlie"));
        Console.WriteLine("Contains value 40: " + dictionary.ContainsValue(40));

        dictionary.Clear();
        Console.WriteLine("\nAfter clearing the dictionary:");
        PrintDictionary(dictionary);
    }

    static void PrintDictionary(Dictionary<string, int> dict)
    {
        foreach (var kvp in dict)
        {
            Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
        }
    }
}

Program 3: Stack<T> 
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");
        stack.Push("Fourth");

        Console.WriteLine("Initial Stack:");
        PrintStack(stack);

        Console.WriteLine($"\nTop element (Peek): {stack.Peek()}");

        stack.Pop();
        Console.WriteLine("\nAfter popping top element:");
        PrintStack(stack);

        Console.WriteLine("\nChecking if stack contains 'Second': " + stack.Contains("Second"));

        string[] array = stack.ToArray();
        Console.WriteLine("\nStack converted to array:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        stack.Clear();
        Console.WriteLine("\nAfter clearing the stack:");
        PrintStack(stack);
    }

    static void PrintStack(Stack<string> stack)
    {
        foreach (var item in stack)
        {
            Console.WriteLine(item);
        }
    }
}
Program 4: Queue<T>
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<double> queue = new Queue<double>();
        queue.Enqueue(1.1);
        queue.Enqueue(2.2);
        queue.Enqueue(3.3);
        queue.Enqueue(4.4);

        Console.WriteLine("Initial Queue:");
        PrintQueue(queue);

        Console.WriteLine($"\nFront element (Peek): {queue.Peek()}");

        queue.Dequeue();
        Console.WriteLine("\nAfter dequeuing the front element:");
        PrintQueue(queue);

        Console.WriteLine("\nChecking if queue contains 3.3: " + queue.Contains(3.3));

        double[] array = queue.ToArray();
        Console.WriteLine("\nQueue converted to array:");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        queue.Clear();
        Console.WriteLine("\nAfter clearing the queue:");
        PrintQueue(queue);
    }

    static void PrintQueue(Queue<double> queue)
    {
        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }
    }
}
Program 5: Combining List, Dictionary, Stack, and Queue
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string> { "Task1", "Task2", "Task3" };
        Dictionary<string, string> taskStatus = new Dictionary<string, string>
        {
            { "Task1", "Pending" },
            { "Task2", "In Progress" },
            { "Task3", "Completed" }
        };

        Stack<string> taskStack = new Stack<string>(tasks);
        Queue<string> taskQueue = new Queue<string>(tasks);

        Console.WriteLine("Tasks in List:");
        foreach (var task in tasks)
        {
            Console.WriteLine($"{task} - {taskStatus[task]}");
        }

        Console.WriteLine("\nTasks in Stack (Last-In-First-Out):");
        while (taskStack.Count > 0)
        {
            string task = taskStack.Pop();
            Console.WriteLine($"Popped: {task} - {taskStatus[task]}");
        }

        Console.WriteLine("\nTasks in Queue (First-In-First-Out):");
        while (taskQueue.Count > 0)
        {
            string task = taskQueue.Dequeue();
            Console.WriteLine($"Dequeued: {task} - {taskStatus[task]}");
        }
    }
}
