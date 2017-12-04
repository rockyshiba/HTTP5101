using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NotTwitter.Models
{
    public class Post
    {
        //Properties
        //Name
        private string _name;
        //Body
        private string _body;
        //char count
        private int _count = 20;
        //char limt
        private int _char_limit = 10;
        //post date
        private DateTime _date = DateTime.Now;

        //Fields
        //Name
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        //Body
        public string Body
        {
            get { return this._body; }
            set { this._body = value.Trim(); }
        }
        //Count
        public string Count
        {
            get { return this._count.ToString(); }
        }
        //Date
        public string Date
        {
            get { return this._date.ToString(); }
        }

        //Method
        public void Count_Post()
        {
            this._count = _body.Length;
        }

        public bool isValid()
        {
            if(this._body.Length <= this._char_limit)
            {
                return true;
            }

            return false;
        }
    }
}