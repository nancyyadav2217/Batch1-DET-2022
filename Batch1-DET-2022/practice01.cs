using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice01
{
    internal class circle
    {
        double radius;
        double diameter;

        public double Radius { get; set; }
        public double Diameter { get; set; }


        double getArea()
        {
            return Math.PI * Radius * Radius;
        }

        double getDiameter()
        {
            return Radius * 2;
        }



        public static void Main()
        {
            circle radiusanddia = new circle
            { Radius = 40, Diameter = 45 };
            double radius = radiusanddia.getArea();
            Console.WriteLine($"the radius is {radius}");
            double diameter = radiusanddia.getDiameter();
            Console.WriteLine($"the diameter is{diameter}");

        }

    }
}