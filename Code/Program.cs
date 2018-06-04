using System;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Printing values after adding in stack");
            stack.Print();
            Console.WriteLine("Printing values after deleting in stack");
            Console.WriteLine("The value poped is {0}", stack.Pop());
            stack.Print();
            Console.WriteLine("Printing the first element in stack which is on top");
            Console.WriteLine("The value on top is {0}", stack.Peek());
            Console.Read();
        }
    }
}
