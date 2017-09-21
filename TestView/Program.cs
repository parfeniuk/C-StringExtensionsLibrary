using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExtensions;

namespace TestView
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "dgfkl dfmljdu54t 46546guety3748-40535091704780 $%^$%^#%@@@%$@";
            Console.WriteLine($"string: {input}");
            Console.WriteLine($"Symbols: {input.Count()}, Letters or Digits:{input.CountNonSpecialSymbols()}");
            input.CountNonSpecialSymbols();


			input = "123 456 7899";
			Console.WriteLine($"\nstring: {input}");
			Console.WriteLine(	$"Words: {input.CountWords()}");

			input = "asd hjk qwe iuyi34 213lkjhl %^$#@ 234";
			Console.WriteLine($"\nstring: {input}");
			Console.WriteLine($"Words: {input.CountWords()}");
			input =
			"Hurricane \"Maria\" is approaching the Dominican Republic \n\"Uruguay \"Maria\" left Puerto Rico without electricity, it has somewhat weakened and is approaching the Dominican Republic.";
			Console.WriteLine($"\nstring: {input}");
			Console.WriteLine($"Words: {input.CountWords()}");







			Console.ReadKey();
        }
    }
}
