using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        static void Main(string[] args)
        {
            Console.Write("Input: ");
            string s = Console.ReadLine();
            Console.Write("Output: ");
            Console.WriteLine(Reverse(s));
        }

        public static string Reverse(string s)
        {
            // optimises for null, empty, and single character inputs
            if (string.IsNullOrEmpty(s) || s.Length == 1)
            {
                return s;
            }

            char[] stringChars = s.ToCharArray();
            Array.Reverse(stringChars);
            return new string(stringChars);
        }
    }
}
