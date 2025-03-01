using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Signal_System_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue trafficQueue = new Queue();
            // Add vehicles to the queue**
           trafficQueue.Enqueue("Car 1");
           trafficQueue.Enqueue("Truck 1"); 
           trafficQueue.Enqueue("Bike 1"); 
           trafficQueue.Enqueue("Bus 1"); 
           Console.WriteLine("Traffic Signal Simulation Started...\n"); 
           while (trafficQueue.Count > 0) 
           {
             
           string vehicle = (string)trafficQueue.Dequeue(); 
           Console.WriteLine($"{vehicle} has passed the signal.\n"); 
           // Display the remaining vehicles**
           if (trafficQueue.Count > 0) 
           {
                 
           Console.WriteLine("Vehicles waiting: " + string.Join(", ",    trafficQueue)); 
           }
           else 
           {
           Console.WriteLine("No vehicles waiting."); 
           }
           Console.WriteLine();
           }
           
           Console.WriteLine("Traffic Signal Simulation Ended."); 
           Console.ReadKey(); 
           
        }
    }
}
