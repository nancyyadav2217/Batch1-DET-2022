using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class OrderingLINQ
    {
        public static void Main()
        {
            ////ex for order by lambda numbers  
            //  int[] numbers = { 7, 9, 5 };

            //  var result = numbers.OrderBy(n => n);

            //  Console.WriteLine("Ordered list of numbers:");
            //  foreach (int number in result)
            //      Console.WriteLine(number);



            //ex for order by descending
            //string[] names = { "Nancy", "Nikita", "Aman" };

            //var result = names.OrderByDescending(n => n);

            //Console.WriteLine("Descending ordered list of names:");
            //foreach (string name in result)
            //    Console.WriteLine(name);


            //ex for order by reverse

             //char[] characters = { 'a', 'p', 'p', 'l', 'e' };

            //var result = characters.Reverse();

            //Console.WriteLine("Characters in reverse order:");
            //foreach (char character in result)
            //    Console.WriteLine(character);



            //ex for order by then by
            //string[] capitals = { "Berlin", "Paris", "Madrid", "Tokyo", "London",
            //              "Athens", "Beijing", "Seoul" };

            //var result = capitals.OrderBy(c => c.Length).ThenBy(c => c);

            //Console.WriteLine("Ordered list of capitals, first by length and then alphabetical:");
            //foreach (string capital in result)
            //    Console.WriteLine(capital);



            //ex for then by descending
            var dates = new DateTime[] {
            new DateTime(2015, 3, 1),
            new DateTime(2014, 7, 1),
            new DateTime(2013, 5, 1),
            new DateTime(2015, 1, 1),
            new DateTime(2015, 7, 1) };
    

            var result = dates.OrderByDescending(d => d.Year).ThenByDescending(d => d.Month);

            Console.WriteLine("List of dates first ordered by year descending, and then by month descending:");
            foreach (DateTime dt in result)
                Console.WriteLine(dt.ToString("yyyy/MM/dd"));
        }

    }
}
