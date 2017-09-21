using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtensions
{
    public static class StringExtensionsLibrary
    {
        public static int CountWords(this string str)
        {
            int count=0;
            return count;
        }
        public static int CountNonSpecialSymbols(this string str)
        {
            int count = 0;
            count= str.Count(c => char.IsLetterOrDigit(c));
            return count;
        }
    }
}
