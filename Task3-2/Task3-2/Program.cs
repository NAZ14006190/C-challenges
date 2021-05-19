using System;
using System.Linq;
using System.Collections.Generic;

namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // set variables
            int[] N = { 9, 88, 1, 9, 88, 87, 35, 12, 50, 23, 12, 1, 4, 9 }; 
            int tempValue;

            // for loop which separates numbers from smallest to biggest. Replaces Array.Sort(C)
            for (int j = 0; j <= N.Length - 2; j++)
            {

                for (int i = 0; i <= N.Length - 2; i++)
                {
                    if (N[i] > N[i + 1])
                    {
                        tempValue = N[i + 1];
                        N[i + 1] = N[i];
                        N[i] = tempValue;

                    }
                }
            }
            List<int> arraysList = new List<int>(); // creating a list to perfrom methods (System.Collections.Generic)
            arraysList.AddRange(N); // adding an array to a list
            int[] C = arraysList.Distinct().ToArray();

            // for loop to output the result
            for (int k = 0; k < C.Length; k++)
            {
                Console.WriteLine(C[k]);
            }
        }
    }
}
