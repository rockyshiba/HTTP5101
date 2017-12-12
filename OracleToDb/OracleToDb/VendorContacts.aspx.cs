using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using OracleToDb.Models;

namespace OracleToDb
{
    public partial class VendorContacts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            string myhost = "calvin.humber.ca";
            string port = "1521";
            string sid = "grok";
            string user = OracleCredentials.username;
            string pass = OracleCredentials.password;
            conn.ConnectionString = OracleConnString(myhost, port, sid, user, pass);

            try
            {
                conn.Open(); //open connection

                string query = "SELECT first_name FROM vendor_contacts"; //query to be executed on database

                OracleCommand cmd = new OracleCommand(query, conn); //apply query to database
                OracleDataReader reader = cmd.ExecuteReader(); //store results of database
                while (reader.Read()) //loop through database rows
                {
                    vendor_contacts.InnerHtml += reader["first_name"] + " ";
                }
                conn.Close(); //close connection
            }
            catch (OracleException excep)
            {
                vendor_contacts.InnerHtml = excep.ToString();
                vendor_contacts.InnerHtml = excep.Message;
                vendor_contacts.InnerHtml = excep.ErrorCode.ToString();
            }
            finally
            {
                vendor_contacts.InnerHtml += " Database operations ceased.";
            }
        }

        public string OracleConnString(string host, string port, string servicename, string user, string pass)
        {
            return String.Format(
              "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={0})" +
              "(PORT={1}))(CONNECT_DATA=(SERVICE_NAME={2})));User Id={3};Password={4};",
              host,
              port,
              servicename,
              user,
              pass);
        }
    }
}