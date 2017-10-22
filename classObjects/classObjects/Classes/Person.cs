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
        private DateTime _date_of_death;

        //fields
        public string First_Name
        {
            //get retrieves a value
            get
            {
                return this._first_name;
            }
            set //set assigns a value
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
            //not all fields require both get and set
            get
            {
                return this._first_name + " " + this._last_name;
            }
        }

        public DateTime Date_Of_Death
        {
            get
            {
                return this._date_of_death;
            }
            set
            {
                if(value > this._date_of_birth)
                {
                    this._date_of_death = value;
                }
            }
        }

        //methods
        //Methods are functions within an object

        /// <summary>
        /// Returns true if the provided age parameter is or older than 18.
        /// Otherwise this method will return false.
        /// </summary>
        /// <param name="age">An integer number to represent a person's age</param>
        /// <returns>A boolean value</returns>
        public bool IsAdult(int age)
        {
            if(age >= 18)
            {
                return true;
            }
            return false;
        }
    }
}