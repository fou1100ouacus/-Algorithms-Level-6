using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Priority_Queue
{
    internal class Program
    {
        class priorityQueue
        {
     private   SortedList<int, int> s = new SortedList<int, int>();
            public  void Enqueue(int val, int priority)
            {
                // Enqueue(10, 1) → Insert 10 with priority 1
                //Enqueue(5, 3) → Insert 5 with priority 3
                //Enqueue(20, 2) → Insert 20 with priority 2
                //Dequeue() → Remove and return 5(highest priority 3)

                // 10 , 5 ,20
                // 1 ,  3 , 2

                s.Add(priority, val);

            }
            public void Dequeue()
            {
                s.Remove(s.Keys.Max());
            }
            public void print()
            {
                Console.WriteLine(string.Join(", ", s.Values));
            }
        }
        
        static void Main(string[] args)
        {
            priorityQueue q=new priorityQueue();
            q.Enqueue(10, 1);
            q.Enqueue(5, 3);
            q.Enqueue(20, 2);

            q.Dequeue();

            q.print();






        }
    }
}
