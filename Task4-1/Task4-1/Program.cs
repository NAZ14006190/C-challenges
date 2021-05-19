using System;

namespace Task4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "XXXYXYXXYYYXYYYYXX";


            char letter = S[0];
            int count = 1; // characters will count at least once
            int currentCount = 0;
            char previousChar = char.MinValue; // MinValue method checks if the previous value is the same or not
          
            char[] array = S.ToCharArray();

            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] != previousChar) // checks of the next characters is the same, if not sets the count to 1
                {
                    currentCount = 1;
                }
                else
                {
                    currentCount++; // if next character is not the same it ads 1 to count
                }

                if (currentCount >= count) // if current count more that one, it assigns the value and letter
                {
                    letter = array[i];
                    count = currentCount; // assigns the amount of repeating characters
                }

                previousChar = array[i]; // assigns the how many characters has been repeated
            }

                string routput = new string(letter, count); // new string, letter mupltiplied by count
                Console.WriteLine($"Number of consecutive characters: {count}. Substring: {routput}"); // Console output
           
            }
        }
    }

