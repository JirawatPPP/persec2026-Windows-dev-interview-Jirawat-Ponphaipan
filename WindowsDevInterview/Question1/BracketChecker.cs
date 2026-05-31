using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsDevInterview.Question1
{
    public static class BracketChecker
    {
        private static readonly Dictionary<char, char> _bracketPairs = new Dictionary<char, char>()
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        public static bool IsBalanced(string input)
        {
            if (string.IsNullOrEmpty(input))
                return true;

            var stack = new Stack<char>();

            foreach (char c in input)
            {
                if (IsOpenBracket(c))
                {
                    stack.Push(c);
                }
                else if (IsCloseBracket(c))
                {
                    if (stack.Count == 0)
                        return false;

                    char top = stack.Pop();
                    if (top != _bracketPairs[c])
                        return false;
                }
            }

            return stack.Count == 0;
        }

        private static bool IsOpenBracket(char c)
        {
            return c == '(' || c == '[' || c == '{';
        }

        private static bool IsCloseBracket(char c)
        {
            return c == ')' || c == ']' || c == '}';
        }
    }
}