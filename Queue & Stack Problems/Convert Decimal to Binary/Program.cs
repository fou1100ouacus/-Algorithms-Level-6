using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Decimal_to_Binary
{
    internal class Program
    {
        static string DecimalToBinary(int number)
    {
        Stack<int> stack = new Stack<int>();

        while (number > 0)
        {
            stack.Push(number % 2);
            number /= 2;
        }

        return string.Join("", stack);
}

// with all cases
        public class Solution {
    public string BaseNeg2(int n) {
        if (n == 0) return "0";
        
        StringBuilder sb = new StringBuilder();
        
        while (n != 0) {
            int remainder = n % -2;
            n /= -2;
            
            // Adjust remainder and n if remainder is negative
            if (remainder < 0) {
                remainder += 2;
                n += 1;
            }
            
            sb.Insert(0, remainder);
        }
        
        return sb.ToString();
    }
}

        static void Main(string[] args)
        {

            Console.WriteLine(DecimalToBinary(100));


        }
    }
}
