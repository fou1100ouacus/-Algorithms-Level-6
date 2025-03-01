using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_a_Queue
{
    internal class Program
    {   static Queue<int> SortQueue(Queue<int>q)
        {
            List<int> list = new List<int>(q);
            list.Sort();
            return new Queue<int>(list);
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 5, 1, 3, 2, 4 }); 
        Queue<int> sortedQueue = SortQueue(queue); 
        Console.WriteLine(string.Join(", ", sortedQueue));
        }
    }
}
