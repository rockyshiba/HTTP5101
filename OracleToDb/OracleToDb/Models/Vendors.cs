using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OracleToDb.Models
{
    public class Vendors
    {
        //Fields
        private int _vendor_id;
        private string _vendor_name;
        private string _vendor_address1;
        private string _vendor_address2;
        private string _vendor_city;
        private string _vendor_state;
        private string _vendor_zip_code;
        private string _vendor_phone;
        private string _vendor_contact_last_name;
        private string _vendor_contact_first_name;
        private int _default_terms_id;
        private int _default_account_number;

        //Properties
        public int Vendor_Id
        {
            get { return this._vendor_id; }
            set { this._vendor_id = value; }
        }

        public string Vendor_Name
        {
            get { return _vendor_name; }
            set { _vendor_name = value; }
        }

        public VendorContacts Vendor_Contact { get; set; }
        public Terms Term { get; set; }
    }
}