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
            string input = "dgfkl    dfmljdu54t      46546guety3748-40535091704780    $%^$%^#%@@@%$@";
            //int wCount = input.Count(c => char.IsWhiteSpace(c))+1;
            Console.WriteLine($"string: {input}");
            Console.WriteLine($"Symbols: {input.Count()}, Letters or Digits:{input.CountNonSpecialSymbols()}, words:{input.CountWords()}");
            input.CountNonSpecialSymbols();


            Console.ReadKey();
        }
    }
}
