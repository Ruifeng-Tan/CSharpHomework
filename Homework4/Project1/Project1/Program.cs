using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        public class Node<T>
        {
            public Node<T> Next { get; set; }
            public T Data { get; set; }
            public Node(T t){
            Next = null;
            Data = t;
            }

                
        }
        
        public class mylist<T>
        {
            private Node<T> head;
            private Node<T> tail;
            public mylist()
            {
                head = tail = null;
            }
            public void ForEach(Action<T> action)
            {
                for (Node<T> x = head; x != null; x = x.Next)
                {
                    action(x.Data);
                }
            }
            public void Add(T t)
            {
                Node<T> n =new Node<T>(t);
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
        }
        static void Main(string[] args)
        {
            mylist<int> list = new mylist<int>();
            //打印列表元素
            for (int x = 0; x < 10; x++)
            {
                list.Add(x);
            }
            list.ForEach(x => Console.WriteLine(x));
            //求和
            int sum = 0;
            list.ForEach(delegate (int x) { sum += x; });
            //求最大值
            int max = 0;
            list.ForEach(delegate (int x) { max = max >= x ? max : x; });
            //求最小值
            int min = 0;
            list.ForEach(delegate (int x) { min = min <= x ? min : x; });
            Console.WriteLine(sum);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.Read();
        }
    }
}
