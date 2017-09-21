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
            Console.WriteLine("Please enter your string :");
            // string str =;
            int count = StringExtensionsLibrary.CountSpecialSymbols(System.Console.ReadLine());
            Console.WriteLine($"In your string {count.ToString()}  special symbols.");

            Console.WriteLine();
            string input = "dgfkl dfmljdu54t 46546guety3748-40535091704780 $%^$%^#%@@@%$@";
            Console.WriteLine($"string: {input}");
            Console.WriteLine($"Symbols: {input.Count()}, Letters or Digits:{input.CountNonSpecialSymbols()}");
            input.CountNonSpecialSymbols();

            Console.ReadKey();
        }
    }
}
