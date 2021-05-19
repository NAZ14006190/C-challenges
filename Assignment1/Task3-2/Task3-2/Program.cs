using System;
using System.Text.RegularExpressions; // using System.Text.RegularExpressions library for Regex method
namespace Task3_2
{
    class Program
    {
        static void Main(string[] args)
        {

           
           
            string P = Console.ReadLine();
            // set variables
            bool valid;
            int maxRepeat = 0;
            // Regex has been used to identify if password matches required criterias
            var hasNumber = new Regex(@"[0-9]+"); // For example, this regex contains numbers from 0-9
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-z]+");
            var hasMiniMaxChars = new Regex(@".{7,}");
            var hasSymbols = new Regex(@"[!@#$%^&*()_+=\[{\]};:<>|./?,-]");


            // checks if there are more than three repeating characters in a row
            for (int i = 0; i < P.Length- 2; i++)
            {

                if (P[i] == P[i + 1] && P[i] == P[i + 2] && P[i] == P[i + 3])
                {
                    
                    maxRepeat = 1;

                }

            }

            // checks if password matched all criterias 
            if (!hasLowerChar.IsMatch(P))
            {
                Console.WriteLine("Error: your password should contain at least one lowercase character!");
                valid = false;
            }
            else if (maxRepeat == 1)
            {
                Console.WriteLine("Error: There were more than three repreating characters in a row!");
                valid = false;
            }
            else if (!hasUpperChar.IsMatch(P))
            {
                Console.WriteLine("Error: your password should contain at least one uppercase character!");
                valid = false;
            }
            else if (!hasMiniMaxChars.IsMatch(P))
            {
                Console.WriteLine("Error: your password contains less than seven characters!");
                valid = false;
            }
            else if (!hasNumber.IsMatch(P))
            {
                Console.WriteLine("Error: your password should contain at least one number!");
                valid = false;
            }
            else if (!hasSymbols.IsMatch(P))
            {
                Console.WriteLine("Error: your password should contain at least one special character!");
                valid = false;
            }
            else
            {
                valid = true;
                Console.WriteLine("Successfull: your password match all requirements");
            }
        }
    }
}
