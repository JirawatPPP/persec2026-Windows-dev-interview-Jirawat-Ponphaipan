using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsDevInterview.Question3
{
    public static class AutoComplete
    {
        public static string[] Autocomplete(string search, string[] items, int maxResult)
        {
            if (string.IsNullOrEmpty(search) || items == null || items.Length == 0)
                return new string[] { };

            return items
                
                .Where(item => item.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0)

                .OrderBy(item => GetPriority(item, search))

                .Take(maxResult)

                .ToArray();
        }

        private static int GetPriority(string item, string search)
        {
            int index = item.IndexOf(search, StringComparison.OrdinalIgnoreCase);
            int lastIndex = item.Length - search.Length;

            if (index == 0) return 1; 
            if (index == lastIndex) return 3; 
            return 2;                        
        }
    }
}
