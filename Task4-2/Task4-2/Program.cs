using System;

namespace Task4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "XXXYXYXXYYYXYYYYXX"; 


            int count = 1; // characters will count at least once
            char letter = ' '; // replacing an empty letter with most constant letter
            int tempCount = 0;
            char previousChar = char.MinValue; // MinValue method checks if the previous value is the same or not

            char[] array = S.ToCharArray();

            // While loop to find the highest consecutive 
                 int i = 0;
                 while (i < S.Length)
                 {

                     if (array[i] == previousChar)
                     {
                         tempCount++;
                     }
                     else
                     {
                         tempCount = 1;
                     }

                     if (tempCount >= count)
                     {
                         letter = array[i];
                         count = tempCount;
                     }

                     previousChar = array[i];
                     i++;
                 }

                 // outtput values
              string routput = new string(letter, count);
              Console.WriteLine("Number of consecutive characters:  {0}. Substring: {1}", count, routput);
            
        }
       


    }
}
