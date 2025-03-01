using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Binary_Numbers
{

public class Solution {
    public IList<string> ValidStrings(int n) {
        var result = new List<string>();
        Generate(result, "", n);
        return result;
    }

    private void Generate(List<string> result, string current, int n) {
        if (current.Length == n) {
            if (IsValid(current)) {
                result.Add(current);
            }
            return;
        }

        Generate(result, current + "0", n);
        Generate(result, current + "1", n);
    }

    private bool IsValid(string s) {
        for (int i = 0; i < s.Length - 1; i++) {
            if (s[i] == '0' && s[i + 1] == '0') {
                return false;
            }
        }
        return true;
    }
}

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
