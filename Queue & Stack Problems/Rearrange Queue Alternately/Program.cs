using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rearrange_Queue_Alternately
{
    internal class Program
    {
        static Queue<int> MergeSortedQueues(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> q = new Queue<int>();
            while (q1.Count > 0 && q2.Count > 0)
            {
                if (q1.Peek() <= q2.Peek())
                {
                    q.Enqueue(q1.Dequeue());

                }
                else
                {
                    q.Enqueue(q2.Dequeue());
                }

            }
            while (q1.Count > 0)
            {
                q.Enqueue(q1.Dequeue());
            }
            while (q2.Count > 0)
            {
                q.Enqueue(q2.Dequeue());
            }
            return new Queue<int>(q);

        }

        static Queue<int> Rearrange(Queue <int> q)
        { 
           List<int> list = new List<int>(q);
                q.Clear();
            for (int i = 0;i<(list.Count)/2;i++)
            {
                q.Enqueue(list[i]);
                q.Enqueue(list[(list.Count)-1-i]);// 0 1 2 3 4 5
                                                  //   1 2 3 4 5 6     n= 6
                if ( (list.Count) % 2 !=0)
                {
                    q.Enqueue((list.Count) / 2);
                }
            }


            return q;
            //split q into two parts
          
        }
        static void Main(string[] args)
        {
//            **Input: Queue = [1, 2, 3, 4, 5, 6] * *
//             **Output: Queue = [1, 6, 2, 5, 3, 4] * *

           Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 }); 
            Queue<int> rearrangedQueue = Rearrange(queue); 
            Console.WriteLine(string.Join(", ", rearrangedQueue)); 



        }
    }
}
