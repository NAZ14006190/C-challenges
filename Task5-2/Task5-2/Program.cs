using System;
//using System.Linq;

namespace Task5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // set vatiables 
            string S = "ABC";
            char[] array = S.ToCharArray();
            char temp;

            // nested for loops with a temp variable to hold a character, while replacing places
            for (int i = 0; i < S.Length; i++)
            {

                for (int j = 0; j < S.Length ; j++)
                {

                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;

                    
                }
                Console.WriteLine(array);

                for (int k = 1; k < S.Length; k++)
                {

                    temp = array[i];
                    array[i] = array[k];
                    array[k] = temp;


                }
               Console.WriteLine(array); // answer is not entirely correct
            }
            
            
                
          
            
      
            /*
            string S = "ABC";
            char[] array = S.ToArray();
            char temp;


            for (int i = 0; i < S.Length; i++)
            {

                for (int j = 0; j < S.Length; j++)
                {

                    temp = array[j];
                    array[j] = array[i];
                    array[i] = temp;

                    //S = new string(array);


                }
                Console.WriteLine(array); // 
                for (int k = 0; k < S.Length - 1; k++)
                {

                    temp = array[k];
                    array[k] = array[i];
                    array[i] = temp;


                }

                Console.WriteLine(array); // 

            }
            */


        }
    }
}
