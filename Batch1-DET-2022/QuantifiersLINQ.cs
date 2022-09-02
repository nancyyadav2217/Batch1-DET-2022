using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class QuantifiersLINQ
    {
        public static void Main()
        {
            quantifiers3();
        }
        private static void quantifiers1()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.All(n => n.StartsWith("B"));

            Console.WriteLine("Does all of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        private static void quantifiers2()
        {
            string[] names = { "Bob", "Ned", "Amy", "Bill" };

            var result = names.Any(n => n.StartsWith("B"));

            Console.WriteLine("Does any of the names start with the letter 'B':");
            Console.WriteLine(result);
        }
        private static void quantifiers3()
        {
            int[] numbers = { 1, 3, 5, 7, 9 };

            var result = numbers.Contains(5);

            Console.WriteLine("sequence contains the value 5:");
            Console.WriteLine(result);
        }


    }
}
