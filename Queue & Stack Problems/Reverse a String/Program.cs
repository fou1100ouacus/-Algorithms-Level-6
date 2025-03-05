using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_String
{
    internal class Program
    {   static string Reverse (string s)
        {
            char[] chars = s.ToCharArray ();
            string output="";
           Stack <char> stack= new Stack<char> ();
            foreach (char c in chars)
            { 
                stack.Push (c);
            }
            while (stack.Count > 0)
            {
                output += stack.Pop();
            }
            return output;
        }
        static void Main(string[] args)
        {

           string o  = Reverse("hello");
            Console.WriteLine(o);
        }
    }
}
