using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    internal class Testcircle
    {
        public static void Main()
        {
            circle ob = new circle(30);
            Console.WriteLine($"Area of circle = {ob.area()} cm square");
        }
    }
}
