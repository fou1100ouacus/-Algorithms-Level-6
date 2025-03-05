using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Middle_Element_in_a_Queue
{
    internal class Program
    {
        static  int Middle(Queue<int> q)
        {
            int middle=0;
            int halflength =( q.Count)/2;
            while (halflength >= 0)
            {
                 middle= q.Dequeue();
                halflength--;
            }
            return middle;
        }
        static int FindMiddle(Queue<int> queue)
        {
            List<int> list = new List<int>(queue);
            return list[list.Count / 2];
        }    

        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3,3,56,45,453, 4,5 });

            Console.WriteLine(Middle(queue));
        }
    }
}
