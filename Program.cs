using System;

namespace StringCalculator
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int vowle = 0, consonant = 0, digit = 0, splChar = 0, space = 0;
            string inputString = Console.ReadLine();

            inputString = inputString.ToLower();

            foreach (char c in inputString)
            {
                if (char.IsDigit(c))
                {
                    digit += 1;
                }
                else if (c.ToString().Equals(" "))
                {
                    space += 1;
                }
                else if (char.IsLetter(c))
                {
                    if (c.ToString().Equals("a") || c.ToString().Equals("e") || c.ToString().Equals("i") || c.ToString().Equals("o") || c.ToString().Equals("u"))
                    {
                        vowle += 1;
                    }
                    else
                    {
                        consonant += 1;
                    }

                }
                else
                {
                    splChar += 1;
                }
            }

            Console.WriteLine(string.Format("No of vowles are : {0}", vowle));
            Console.WriteLine(string.Format("No of consonants are : {0}", consonant));
            Console.WriteLine(string.Format("No of digits are : {0}", digit));
            Console.WriteLine(string.Format("No of spaces are : {0}", space));
            Console.WriteLine(string.Format("No of special characters are : {0}", splChar));
        }
    }
}
