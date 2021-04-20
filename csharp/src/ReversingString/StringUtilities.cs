using System;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        static void Main(string[] args)
        {
            string str="", reverse="";
            int Length=0;
            Console.Writeline("Enter any string");
            str=Console.Readline();
            Length=str.Length-1;
            while(Length>=0)
            {
                reverse=reverse+str.Length;
                Length--;
                
            }
            Console.WriteLine("Reverse string is {0}",reverse);
           
        }
     }
    
}
