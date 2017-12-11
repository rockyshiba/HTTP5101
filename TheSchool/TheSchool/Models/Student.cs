using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student : Person //Class Student inheriting the Person class
    {
        //Fields
        private string _s_id;
        private string _program;
        private double _gpa;

        //Properties
        public string Country
        {
            get { return this.country; }
        }

        public string S_Id
        {
            get { return this._s_id; }
            set { this._s_id = value; }
        }

        public string Program
        {
            get { return this._program; }
            set { this._program = value; }
        }

        public double Gpa
        {
            get { return this._gpa; }
            set { if(value > 0) { this._gpa = value; } else { this._gpa = 0; } }
        }
        //Methods
        public void Add_Sub_Gpa(double num)
        {
            this._gpa = this._gpa + num;
            if(this._gpa < 0)
            {
                this._gpa = 0;
            }
        }

    }
}
