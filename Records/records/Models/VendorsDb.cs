using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace records.Models
{
    public class VendorsDb : CalvinDb
    {
        //Properties
        private string vendor_id;
        private string vendor_name;
        private string vendor_address1;
        private string vendor_address2;
        private string vendor_city;
        private string vendor_state;
        private string vendor_zip_code;
        private string vendor_phone;
        private string vendor_contact_last_name;
        private string vendor_contact_first_name;
        private string default_terms_id;
        private string default_account_number;

        //Fields
        public string Vendor_Id { get { return vendor_id; } }
        public string Vendor_Name { get { return vendor_name; } }
        public string Vendor_Address1 { get { return vendor_address1; } }
        public string Vendor_Address2 { get { return vendor_address2; } }
        public string Vendor_City { get { return vendor_city; } }
        public string Vendor_State { get { return vendor_state; } }
        public string Vendor_Zip_Code { get { return vendor_zip_code; } }
        public string Vendor_Phone { get { return vendor_phone; } }
        public string Last_Name { get { return vendor_contact_last_name; } }
        public string First_Name { get { return vendor_contact_first_name; } }
        public string Default_Terms_Id { get { return default_terms_id; } }
        public string Default_Account_Number { get { return default_account_number; } }

        public string Full_Name { get { return First_Name + " " + Last_Name; } }

        protected List<VendorsDb> vendors = new List<VendorsDb>();

        /// <summary>
        /// Retrieves all columns from the Vendors table
        /// </summary>
        /// <returns>List of type VendorsDb</returns>
        public List<VendorsDb> GetAll()
        {
            string allQuery = "SELECT * FROM vendors";
            vendors.Clear();

            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new OracleCommand(allQuery, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VendorsDb thisVendor = new VendorsDb();
                    thisVendor.vendor_id = reader["vendor_id"].ToString();
                    thisVendor.vendor_name = reader["vendor_name"].ToString();
                    thisVendor.vendor_address1 = reader[2].ToString();
                    thisVendor.vendor_address2 = reader[3].ToString();
                    thisVendor.vendor_city = reader[4].ToString();
                    thisVendor.vendor_state = reader[5].ToString();
                    thisVendor.vendor_zip_code = reader[6].ToString();
                    thisVendor.vendor_phone = reader[7].ToString();
                    thisVendor.vendor_contact_last_name = reader[8].ToString();
                    thisVendor.vendor_contact_first_name = reader[9].ToString();
                    thisVendor.default_terms_id = reader[10].ToString();
                    thisVendor.default_account_number = reader[11].ToString();

                    vendors.Add(thisVendor);
                }
                reader.Close();
                conn.Close();
            }
            catch(OracleException ex)
            {
                VendorsDb exceptionVendor = new VendorsDb();
                exceptionVendor.vendor_id = ex.ErrorCode.ToString();
                exceptionVendor.vendor_name = ex.ErrorCode.ToString();
                vendors.Add(exceptionVendor);
            }

            return vendors;
        }

        /// <summary>
        /// Returns a list of vendors from the Vendors table based on a name
        /// </summary>
        /// <param name="vendor_name">A vendor's name as a string</param>
        /// <returns>List of VendorDb objects</returns>
        public List<VendorsDb> GetAll(string vendor_name)
        {
            //Thank you, OMG Ponies https://stackoverflow.com/questions/3790424/usage-of-oracle-binding-variables-with-like-in-c-sharp
            string searchQuery = "SELECT * " +
                "FROM vendors " +
                "WHERE vendor_name LIKE :vname || '%'";

            vendors.Clear();

            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new OracleCommand(searchQuery, conn);
                //Thank you, James Lawruk https://stackoverflow.com/questions/12812634/how-to-write-parameterized-oracle-insert-query
                cmd.Parameters.Add(new OracleParameter("vname", vendor_name));
                
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    VendorsDb thisVendor = new VendorsDb();
                    thisVendor.vendor_id = reader["vendor_id"].ToString();
                    thisVendor.vendor_name = reader["vendor_name"].ToString();
                    thisVendor.vendor_address1 = reader[2].ToString();
                    thisVendor.vendor_address2 = reader[3].ToString();
                    thisVendor.vendor_city = reader[4].ToString();
                    thisVendor.vendor_state = reader[5].ToString();
                    thisVendor.vendor_zip_code = reader[6].ToString();
                    thisVendor.vendor_phone = reader[7].ToString();
                    thisVendor.vendor_contact_last_name = reader[8].ToString();
                    thisVendor.vendor_contact_first_name = reader[9].ToString();
                    thisVendor.default_terms_id = reader[10].ToString();
                    thisVendor.default_account_number = reader[11].ToString();

                    vendors.Add(thisVendor);
                }
                reader.Close();
                conn.Close();
            }
            catch(OracleException ex)
            {
                VendorsDb exceptionVendor = new VendorsDb();
                exceptionVendor.vendor_id = ex.ErrorCode.ToString();
                exceptionVendor.vendor_name = ex.ErrorCode.ToString();
                vendors.Add(exceptionVendor);
            }

            return vendors;
        }
    }
}