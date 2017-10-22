using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Rectangle : Shape
    {
        public double Area()
        {
            return this.Height * this.Length;
        }

        public double Area(double height, double length)
        {
            return height * length;
        }
    }
}