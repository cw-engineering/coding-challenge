using System.Collections;
using System.Text;

namespace CodingChallenge.ReversingString
{
    public class StringUtilities
    {
        public static string Reverse(string s)
        {
            var stackOfChars = new Stack();
            var str = new StringBuilder();

            PushCharsOnStack(s, stackOfChars);
            RemoveCharsFromStackInReverseOrder(stackOfChars, str);

            return str.ToString();
        }

        private static void RemoveCharsFromStackInReverseOrder(Stack stackOfChars, StringBuilder str)
        {
            while (stackOfChars.Count != 0)
            {
                str.Append(stackOfChars.Pop());
            }
        }

        private static void PushCharsOnStack(string s, Stack stackOfChars)
        {
            foreach (var ch in s.ToCharArray())
            {
                stackOfChars.Push(ch);
            }
        }
    }
}
