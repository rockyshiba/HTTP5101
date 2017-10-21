using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Person
    {
        //properties
        private string _first_name;
        private string _last_name;
        private DateTime _date_of_birth;

        //fields
        public string First_Name
        {
            get
            {
                return this._first_name;
            }
            set
            {
                //[object]._first_name = "Robert";
                //The keyword value is a placeholder for whatever value you provide it
                //Keep in mind that C# is a typed language. Notice after public there is a type, in this case type string.
                //Value must match that type
                this._first_name = value;
            }
        }

        public string Last_Name
        {
            get
            {
                return this._last_name;
            }
            set
            {
                this._last_name = value;
            }
        }

        public string Full_Name
        {
            get
            {
                return this._first_name + " " + this._last_name;
            }
        }

        //methods
    }
}