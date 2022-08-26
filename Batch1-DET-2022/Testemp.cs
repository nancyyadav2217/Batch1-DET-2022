using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testemp
    {
      public static void Main()
        {
            emp e = new emp(5050, "Nancy", new DateOnly(2020, 8, 1));
            Console.WriteLine( $"Years of experience{e.GetYearsofExp()}");
        }
    }
}
