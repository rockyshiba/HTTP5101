using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotTwitter.Models
{
    public class Person
    {
        //Properties
        private string _first_name;
        private string _last_name;
        private DateTime _dob;

        //Fields
        public string First_Name
        {
            set { this._first_name = value; }
        }

        public string Last_Name
        {
            set { this._last_name = value; }
        }

        public string Full_Name
        {
            get { return this._first_name + " " + this._last_name; }
        }

        public DateTime Dob
        {
            set { this._dob = value; }
            get { return this._dob; }
        }
    }
}