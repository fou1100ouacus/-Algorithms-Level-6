using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implement_Browser_Back_Button
{
    internal class Program
    {
        static void Main(string[] args)
        {
   Stack<string> button = new Stack<string>();

            button.Push("Page1");
            button.Push("Page2");
            button.Push("Page3");
            button.Push("Page4");

            Console.WriteLine("Back from: " + button.Pop());
            Console.WriteLine("Current Page: " + button.Peek());// object of the top of stack
           
        }
    }
}
