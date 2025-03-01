using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Undo_Operations_in_a_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack calculatorStack = new Stack();
            calculatorStack.Push(10);
            calculatorStack.Push(20);
            calculatorStack.Push(30);

            Console.WriteLine("Back from: " + calculatorStack.Pop());
            Console.WriteLine("Current Page: " + calculatorStack.Peek());// object of the top of stack
        }
    }
}
