using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clone_a_Queue_Without_Using_Extra_Space
{
    internal class Program
    {
        static Queue<int> Clonequeue(Queue<int> OriginalQueue)
        {
            Queue<int> q = new Queue<int>();
            if (OriginalQueue.Count==0)
            {
                return new Queue<int>();
            }
            int front=OriginalQueue.Dequeue();
            Queue<int> Clone = Clonequeue(OriginalQueue);
            OriginalQueue.Enqueue(front);// this step  for output 
            Clone.Enqueue(front);

            return Clone;
        }
            static void Main(string[] args)
            {

            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4 }); 
            Queue<int> clonedQueuee = Clonequeue(queue); 
            Console.WriteLine(string.Join(", ", clonedQueuee)); // Output: 1, 2, 3, 4**`
            Console.WriteLine(string.Join(", ", queue));
        }

    }
}
