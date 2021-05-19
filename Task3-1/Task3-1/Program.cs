using System;
using System.Linq; // Using System.Linq!!!

namespace Task3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // set variables
            string P = Console.ReadLine();
            bool valid;
            string special = @"|!#$%&/()=?@~£{}.-;'<>_,";
            int criteria = 0; // criteria starts with 0 and adds 1 when it meets each criteria


            // checks if password is at least 7 characters long
            if (P.Length >= 7)
            {
                criteria++;
                    
            }
            else //(P.Length <= 6)
            {
                Console.WriteLine("Error: your password contains less than seven characters!");
            }

            // checks if pasword contains letter of numbers and if there are at least one upper and lower
            if (P.Any(char.IsUpper) && P.Any(char.IsLower) && P.Any(char.IsLetterOrDigit)) 
            {
                criteria++;
            }
            else
            {
                Console.WriteLine("Error: your password should contain at least one uppercase, lowercase and a number!");
            }

            // checks is password contains at least one special character 
            foreach (var item in special)
            {
                if (P.Contains(item))
                {
                    criteria++;
                }
            }
            if (criteria != 3)
            {
                Console.WriteLine("Error: your password should contain at least one special character!");
            }

            // checks if there are more than three repeating characters in a row
            for (int i = 0; i < P.Length - 2; i++)
            {

                if (P[i] == P[i + 1] && P[i] == P[i + 2] && P[i] == P[i + 3])
                {
                    //Console.WriteLine("Error: There were more than three repreating characters in a row!");
                    criteria = 0;

                }
               
            }
            if (criteria != 3)
            {
                Console.WriteLine("Error: There were more than three repreating characters in a row!");
            }

            // checks if password matched all criterias 
            if (criteria == 3)
            {

                valid = true;
                Console.WriteLine("Successfull: your password match all requirements");
            }
            else
            {
                valid = false;
                Console.WriteLine("Unsuccessful: your password did not meet one or more requirements");
            }
        }
    }
}
