using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interleave_Queue_Elements
{
    internal class Program
    {
    static void InterleaveQueue(Queue<int> queue)
   {
             int halfSize = queue.Count / 2;
             Stack<int> stack = new Stack<int>();

            for (int i = 0; i<halfSize; i++)
            {
                    stack.Push(queue.Dequeue());
            }
               while (stack.Count > 0)
               {
                      queue.Enqueue(stack.Pop());
    
               }
    
            for (int i = 0; i < halfSize; i++) 
            {
            
             queue.Enqueue(queue.Dequeue()); 
            }
            
            
            for (int i = 0; i < halfSize; i++) 
            {
            
             stack.Push(queue.Dequeue()); 
            }
            
            
            while (stack.Count > 0) 
            {
            
               queue.Enqueue(stack.Pop()); 
               queue.Enqueue(queue.Dequeue()); 
            }
            
         }

     static void Main(string[] args)
        {Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5, 6 }); 
        InterleaveQueue(queue); 
        Console.WriteLine(string.Join(", ", queue)); 
        Console.ReadKey(); 
     }
    }
}
