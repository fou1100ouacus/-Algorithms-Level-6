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

public class Solution {
    public bool IsPalindrome(string s) {
        // Convert to lowercase and remove non-alphanumeric characters
        string cleaned = new string(s.Where(c => char.IsLetterOrDigit(c)).ToArray());
        cleaned = cleaned.ToLower();

        // Add characters to the queue
        var queue = new Queue<char>();
        foreach (char c in cleaned) {
            queue.Enqueue(c);
        }

        // Compare characters from the queue with the cleaned string from the end
        for (int i = cleaned.Length - 1; i >= 0; i--) {
            if (queue.Dequeue() != cleaned[i]) {
                return false;
            }
        }

        return true;
    }
}

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
