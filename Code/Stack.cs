using System;

namespace Collection
{
    public class Stack<T>
    {
        private Node<T> top = null;

        public void Push (T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (top == null)
            {
                top = newNode;
                top.previous = null;
                return;
            }
            Node<T> first = top;
            while (first.next != null)
            {
                first = first.next;
            }
            first.next = newNode;
            top = first.next;
            top.previous = first;
        } 

        public T Pop()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty");
                return default(T);
            }
            Node<T> toDelete = top;
            Node<T> toReturn = toDelete;
            if (toDelete != null)
            {
                top = toDelete.previous;
                toDelete = null;
            }
            return toReturn.item;
        }

        public T Peek()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty");
                return default(T);
            }
            return top.item;
        }

        public void Print()
        {
            Node<T> element = top;
            while (element != null)
            {
                Console.WriteLine(element.item);
                element = element.previous;
            }
        }
    }
}
