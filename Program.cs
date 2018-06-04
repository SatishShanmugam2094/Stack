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
            stack.Pop();
            stack.Print();
            Console.WriteLine("Printing the first element in stack which is on top");
            stack.Peek();
            Console.Read();
        }
    }
}
