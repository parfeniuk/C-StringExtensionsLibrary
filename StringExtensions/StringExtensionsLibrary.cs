using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace StringExtensions
{
    public static class StringExtensionsLibrary
    {
        public static int CountWords(this string str)
        {
			//Fixed додано десяткові числа як слова
			int count = 0;
			Regex regex = new Regex(@"\b");
			MatchCollection matches = regex.Matches(str);
			
			if (matches.Count > 0)
			{
				count = matches.Count/2;				
			}
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
