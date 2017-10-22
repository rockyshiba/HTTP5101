using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Triangle : Shape //Class Triangle inherites class Shape
    { 
        //A method that returns the area of the triangle object
        public double Area()
        {
            return this.Height * this.Length / 2;
        }

        //An overloaded method. Same name as the previous method but has different parameters. C# permits this.
        //Generally, with overloaded methods you should keep the theme of the overloads consistent.
        public double Area(double height, double length)
        {
            return height * length / 2;
        }
    }
}