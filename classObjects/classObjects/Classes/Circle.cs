using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Circle : Shape
    {
        public double Area()
        {
            return Math.PI * Math.Pow(this.Radius, 2);
        }

        public static double Area(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}