using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1
{
    class Task3a
    {
        static void Main(string[] args)
        {
      

      
            int[] N = { 9, 88, 1, 9, 88, 87, 35, 12, 50, 23, 12, 1, 4, 9 }; 

            List<int> arraysList = new List<int>(); // (System.Collections.Generic)
            arraysList.AddRange(N); 
            int[] C = arraysList.Distinct().ToArray(); // System.Linq
            Array.Sort(C); 

            foreach (int i in C) 
            {
                Console.WriteLine(i); 
            }

        }
    }
}