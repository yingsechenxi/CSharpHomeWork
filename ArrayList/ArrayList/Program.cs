using System;

namespace ArrayList
{
    public class Node<T>
    {
        public Node<T> Next { get; set; }
        public T Data { get; set; }
        public Node(T t)
        {
            Next = null;
            Data = t;
        }
    }
    public class GenericList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        public GenericList()
        {
            head = tail = null;
        }
        public Node<T> Head
        {
            get => head;
        }
        public void Add(T t)
        {
            Node<T> n = new Node<T>(t);
            if (tail == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
        }
        public void ForEach(Action<T> action)
        {
            for (Node<T> a = head; a != null; a = a.Next)
            {
                action(a.Data);
            }
        }
    }
class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, min = 0, max = 0;
            GenericList<int> firstlist = new GenericList<int>();
            firstlist.ForEach(x => Console.WriteLine(x));
            firstlist.ForEach(x => sum += x);
            firstlist.ForEach(x => { if (max < x) max = x; });
            firstlist.ForEach(x => { if (min > x) min = x; });
            Console.Write(sum+" "+max+" "+min);
        }
    }
}
