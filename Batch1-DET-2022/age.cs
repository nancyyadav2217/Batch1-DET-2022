/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class age
    {
        public static int age(DateTime dob)
        {
            int CurrentYear = DateTime.Now.Year;
            int CurrentMonth = DateTime.Now.Month;
            return CurrentYear - CurrentMonth;

        }
         public static void Main()
        {
            DateTime date = DateTime.Parse(Console.ReadLine());
            int res = age(date);
            Console.WriteLine($"your age is(res)");

        }

    }
}
*/