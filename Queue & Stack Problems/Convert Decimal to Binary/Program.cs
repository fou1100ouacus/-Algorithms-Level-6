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


        static void Main(string[] args)
        {

            Console.WriteLine(DecimalToBinary(100));


        }
    }
}
