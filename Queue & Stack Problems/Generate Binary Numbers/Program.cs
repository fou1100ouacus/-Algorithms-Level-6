using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Binary_Numbers
{
    internal class Program
    {
        static Queue<int> DecimalToBinaryUsingQueue(int number)
        {
              Queue<int> queue = new Queue<int>();    
            while (number > 0)
            {
                queue.Enqueue(number % 2);
                number /= 2;
            }

            return queue;
        }


    static void GenerateBinaryNums(int num)
    {
             Queue<string> queue = new Queue<string>();
                    queue.Enqueue("1");
                for (int i = 0; i< num; i++)
                {
                   string binary = queue.Dequeue();
                    Console.WriteLine(binary);
                    queue.Enqueue(binary + "0");
                    queue.Enqueue(binary + "1");
                }
    }
        static void Main(string[] args)
        {
            GenerateBinaryNums(7);  // 64 32 16 8 4 2 1 
           
        }
    }
}
