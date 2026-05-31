using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDevInterview.Question5
{
    public static class DigitSorter
    {
        public static int SortDescending(int number)
        {        
            if (number <= 0)
                throw new ArgumentException("ต้องเป็น Positive Int เท่านั้น");
    
            string sorted = string.Concat(
                number.ToString()
                      .OrderByDescending(c => c)
            );

            return int.Parse(sorted);
        }
    }
}