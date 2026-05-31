using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDevInterview.Question6
{
    public static class TribonacciSequence
    {
        public static int[] Tribonacci(int[] signature, int n)
        {
            if (n == 0)
                return new int[] { };

            if (signature == null)
                throw new ArgumentNullException("signature");

            if (n < 0)
                throw new ArgumentException("n ต้องเป็น non negative int");

            var padded = new int[3];
            int startIndex = 3 - signature.Length;

            for (int i = 0; i < signature.Length; i++)
                padded[startIndex + i] = signature[i];

            if (n <= 3)
                return padded.Take(n).ToArray();

            var result = new List<int>(padded);

            while (result.Count < n)
            {
                int count = result.Count;
                int next = result[count - 1]
                         + result[count - 2]
                         + result[count - 3];
                result.Add(next);
            }

            return result.ToArray();
        }
    }
}
