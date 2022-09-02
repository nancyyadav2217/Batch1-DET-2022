using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class LearninglinQ
    {
        public static void Main()
        
            
        
        //// The Data Parts of a LINQ query: deferred execution
        //// // 1. Data source.
        //List<int> numbers = new List<int>();
        //numbers.Add(110);
        //numbers.Add(100);
        //numbers.Add(105);
        //numbers.Add(103);

        //// 2. query creation. sql type
        ////ex for deferred execution
        ////var numQuery = from num in numbers //select num from numbers
        ////               where num>102
        ////               select num;
        ////numbers.Add(300);
        ////numbers.Add(350);

        //////early execution
        ////var numQuery = (from num in numbers //select num from numbers
        ////               select num).ToList();
        ////numbers.Add(300);

        ////lambda exp
        //var numQuery = numbers.Where(x => x>102);


        ////3. Query execution.

        //foreach (int num in numQuery)
        //{
        //    Console.WriteLine("{0}",num);
        //    //num.Dump(); // this is for LINQpad not forVS
        //}
        //Console.ReadLine();


       
        {
            List<string> words = new List<string> { "basket", "blueberry", "chimpanze", "abascus", "banana", "apple", "cheese" };

            var wordGroups = words.GroupBy(x => x[0]).Select
                (y => new { FirstLetter = y.Key, Words = y });

            foreach (var item in wordGroups)
            {
                Console.WriteLine("Words that start with the" + 
                    " letter '{O}':",
                    item.FirstLetter);

                foreach (var w in item.Words)
                {
                    Console.WriteLine(w);
                }

            }
        }
    }
}



