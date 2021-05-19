using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // set variables
            string S = "ABC";
            char temp = ' ';

            // for loop and replace method to replace each letter with temporary character and output the result
            for (int i = 0; i < S.Length; i++)
            {

                S = S.Replace(S[1], temp).Replace(S[2], S[1]).Replace(temp, S[2]);
                for (int j = 1; j < S.Length; j++)
                {
                    S = S.Replace(S[1], temp).Replace(S[2], S[1]).Replace(temp, S[2]);
                    Console.WriteLine(S);
                }

                for (int k = 2; k < S.Length; k++)
                {
                    S = S.Replace(S[0], temp).Replace(S[1], S[0]).Replace(temp, S[1]);

                }


            }
        }
    }
}
