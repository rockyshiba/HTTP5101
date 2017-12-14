using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OracleToDb.Models
{
    public class Terms
    {
        //Fields
        private int _terms_id;
        private string _terms_description;
        private int _terms_due_days;

        //Properties
        public int Terms_Id
        {
            get { return this._terms_id; }
            set { this._terms_id = value; }
        }

        public string Terms_Description
        {
            get { return this._terms_description; }
            set { this._terms_description = value; }
        }

        public int Terms_Due_Days
        {
            get { return this._terms_due_days; }
            set { this._terms_due_days = value; }
        }
    }
}