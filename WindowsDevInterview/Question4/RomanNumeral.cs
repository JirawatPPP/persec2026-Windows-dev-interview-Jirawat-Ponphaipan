using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDevInterview.Question4
{
    public static class RomanNumeral
    {
        
        private static readonly (int value, string symbol)[] _table = new[]
        {
            (1000, "M"),  (900, "CM"), (500, "D"),  (400, "CD"),
            (100,  "C"),  (90,  "XC"), (50,  "L"),  (40,  "XL"),
            (10,   "X"),  (9,   "IX"), (5,   "V"),  (4,   "IV"),
            (1,    "I")
        };

        private static readonly Dictionary<char, int> _romanMap = new Dictionary<char, int>
        {
            { 'I', 1   },
            { 'V', 5   },
            { 'X', 10  },
            { 'L', 50  },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000}
        };

        public static string ToRoman(int number)
        {
            if (number <= 0 || number > 3999)
                throw new ArgumentOutOfRangeException("number", "ต้องอยู่ระหว่าง 1 - 3999");

            var result = new StringBuilder();

            foreach (var (value, symbol) in _table)
            {
                while (number >= value)
                {
                    result.Append(symbol);
                    number -= value;
                }
            }

            return result.ToString();
        }

        public static int ToInt(string roman)
        {
            if (string.IsNullOrEmpty(roman))
                throw new ArgumentNullException("roman", "ห้ามเป็น null หรือ empty");

            int result = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                int current = _romanMap[roman[i]];

                if (i + 1 < roman.Length)
                {
                    int next = _romanMap[roman[i + 1]];
                    if (current < next)
                    {
                        result -= current;
                        continue;
                    }
                }

                result += current;
            }

            return result;
        }
    }
}
