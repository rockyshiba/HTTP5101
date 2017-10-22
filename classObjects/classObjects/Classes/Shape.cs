using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Shape
    {
        //Properties
        private double _length;
        private double _height;
        private double _radius;

        //Fields
        public double Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        public double Height
        {
            get { return this._height; }
            set { this._height = value; }
        }

        public double Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }
    }
}