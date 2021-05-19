using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set variables
            int[] A = { 3, 5, 2, 1, 7, 4 }; 
            int T = 14;
            int total = 0;
            int answer = 0; 

            // for loop to go through all numbers in array
            for (int i = 0; i < A.Length; i++)
            {

                // adds numbers until is less than 14
                if ((total += A[i]) <= T)
                {
                    answer += A[i];

                }
                else
                {
                    Console.WriteLine("Total Items added: " + i); 
                    Console.WriteLine("TOTAL VALUE: " + answer);
                    break;
                }


            }
        }
    }
}
