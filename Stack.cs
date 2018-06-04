using System;

namespace Collection
{
    public class Stack<T>
    {
        private Node<T> last = null;

        public void Push (T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (last == null)
            {
                last = newNode;
                last.previous = null;
                return;
            }
            Node<T> first = last;
            while (first.next != null)
            {
                first = first.next;
            }
            first.next = newNode;
            last = first.next;
            last.previous = first;
        }
        public void Pop()
        {
            if (last == null)
            {
                Console.WriteLine("The stack is empty");
                return;
            }
            Node<T> toDelete = last;
            if (toDelete != null)
            {
                last = toDelete.previous;
                toDelete = null;
            }
        }
        public void Peek()
        {
            if (last == null)
            {
                Console.WriteLine("Thestack is empty");
                return;
            }
            Console.WriteLine(last.item);
        }
        public void Print()
        {
            Node<T> element = last;
            while (element != null)
            {
                Console.WriteLine(element.item);
                element = element.previous;
            }
        }
    }
}
