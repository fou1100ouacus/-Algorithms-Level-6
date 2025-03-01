﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Simple_Backtracking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Stack<string> path = new Stack<string>();


        Console.WriteLine("Start -> Go to Gaz Station -> Go to Super Market -> Go To Work -> Go to Cafe -> Go Home.\n"); 
       
        


       path.Push("Start");
       path.Push("Go to Gaz Station"); 
       path.Push("Go to Super Market");
       path.Push("Go To Work"); 
       path.Push("Go to Cafe");
       path.Push("Go Home"); 


       // Backtracking**`
       Console.WriteLine("Backtracking...\n"); 
       while (path.Count > 0) 
       {
           
       Console.WriteLine($"Back to: {path.Pop()}"); 
       }
       Console.ReadKey(); 
       
    }


    
    }
}
