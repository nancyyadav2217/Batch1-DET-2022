using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class AggregrateLINQ
    {
        public static void Main()
        {
            Aggregrate5();
        }

        private static void Aggregrate1()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        private static void Aggregrate2()
        {
            //Average
            int[] numbers = { 10, 10, 11, 11 };

            var result = numbers.Average();

            Console.WriteLine("Average is:");
            Console.WriteLine(result);

        }

        private static void Aggregrate3()
        {
            //Count
            string[] names = { "Nancy", "Chaitra", "Harshitha", "Monika", "Nikita" };

            var result = names.Count();

            Console.WriteLine("Counting names gives:");
            Console.WriteLine(result);
        }





        private static void Aggregrate4()
        {
            //max
            int[] numbers = { 2, 8, 5, 6, 1 };

            var result = numbers.Max();

            Console.WriteLine("Highest number is:");
            Console.WriteLine(result);
        }

        private static void Aggregrate5()
        {
            //min
            int[] numbers = { 6, 9, 3, 7, 5 };

            var result = numbers.Min();

            Console.WriteLine("Lowest number is:");
            Console.WriteLine(result);
        }

       

        //sum
        private static void Aggregrate6()
        {
            int[] numbers = { 5, 10, 20 };

            var result = numbers.Sum();

            Console.WriteLine("Summing the numbers yields:");
            Console.WriteLine(result);
        }
        
    }
}

