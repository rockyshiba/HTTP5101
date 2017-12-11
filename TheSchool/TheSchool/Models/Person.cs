using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        //Fields
        private string _first_name;
        private string _last_name;
        private DateTime _date_of_birth;

        protected string country;

        //Properties
        public string First_Name
        {
            get { return this._first_name; }
            set { this._first_name = value; }
        }
        //Lee.First_Name; GET
        //Lee.First_Name = "some name"; SET

        public string Last_Name
        {
            get { return this._last_name; }
            set { this._last_name = value; }
        }

        public string Full_Name
        {
            get { return this._first_name + " " + this._last_name; }
        }

        public DateTime Date_Of_Birth
        {
            get { return this._date_of_birth; }
            set { this._date_of_birth = value; }
        }

        //Methods
        public string Hello()
        {
            return "Hi my name is " + this.Full_Name; //Lee.Hello() -> Hi my name is Lee S
        }

        public void Set_First_Name(string name)
        {
            this._first_name = name;
        }
    }
}
