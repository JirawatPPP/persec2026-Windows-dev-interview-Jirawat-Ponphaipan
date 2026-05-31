using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsDevInterview.Question2
{

    public static class Array
    {
        public static string[] SortStrings(string[] input)
        {
            if (input == null || input.Length == 0)
                return input;

            var result = new List<string>(input);

            result.Sort((a, b) =>
            {
                var partA = SplitString(a);
                var partB = SplitString(b);

                int prefixCompare = string.Compare(
                    partA.prefix,
                    partB.prefix,
                    StringComparison.OrdinalIgnoreCase
                );
                if (prefixCompare != 0)
                    return prefixCompare;

                if (partA.number != partB.number)
                    return partA.number.CompareTo(partB.number);

                return string.Compare(
                    partA.suffix,
                    partB.suffix,
                    StringComparison.OrdinalIgnoreCase
                );
            });

            return result.ToArray();
        }

        private static (string prefix, int number, string suffix) SplitString(string input)
        {
            var match = Regex.Match(input, @"^([a-zA-Z]+)(\d+)(.*)$");

            if (match.Success)
            {
                return (
                    match.Groups[1].Value,           
                    int.Parse(match.Groups[2].Value), 
                    match.Groups[3].Value             
                );
            }

            return (input, 0, "");
        }
    }
}