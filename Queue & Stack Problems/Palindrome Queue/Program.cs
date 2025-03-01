using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Queue
{
    internal class Program
    {
        static bool IsPalindrome(Queue<int> queue)
        {
           Stack<int> stack = new Stack<int>(queue);//reversed queue
           foreach (int item in queue)
            {
                if (stack.Pop()!=item)
                {
                    return false;

                }
            }
           return true;
        }
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 2, 1 }); 
            Console.WriteLine(IsPalindrome(queue));



        }//same forwards and backwards

    }
}
