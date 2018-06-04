namespace Collection
{
    public class Node<T>
    {
        public Node<T> next = null;
        public Node<T> previous = null;
        public T item;

        public Node(T value)
        {
            item = value;
        }
    }
}
