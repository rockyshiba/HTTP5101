using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace classObjects.Classes
{
    public class Webpage
    {
        //Properties
        private string _title;
        private string _header;
        private string _body;
        private string _footer;
        private string _css;

        //Fields
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public string Header
        {
            get
            {
                return "<header>" + this._header + "</header>";
            }
            set
            {
                this._header = value;
            }
        }

        public string Body
        {
            get
            {
                return this._body;
            }
            set
            {
                this._body = value;
            }
        }

        public string Footer
        {
            get
            {
                return "<footer>" + this._footer + "</footer>";
            }
            set
            {
                this._footer = value;
            }
        }

        public string Css
        {
            get
            {
                return this._css;
            }
            set
            {
                this._css = value;
            }
        }
    }
}