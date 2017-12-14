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

        protected static string myhost = "calvin.humber.ca";
        protected static string port = "1521";
        protected static string sid = "grok";
        protected static string user = OracleCredentials.username;
        protected static string pass = OracleCredentials.password;
        protected static string connectionString = OracleConnString(myhost, port, sid, user, pass);
        OracleConnection conn = new OracleConnection(connectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

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
                //vendor_contacts.InnerHtml = excep.ErrorCode.ToString();
            }
            finally
            {
                vendor_contacts.InnerHtml += " Database operations ceased.";
            }
        }

        protected void btn_add_vendor_contact_Click(object sender, EventArgs e)
        {
            string vendor_id = txt_vendor_id.Text;
            string vendor_last_name = txt_vendor_last_name.Text;
            string vendor_first_name = txt_vendor_first_name.Text;
            string vendor_email = txt_vendor_email.Text;

            int rows = 0;
            try
            {
                conn.Open();

                string command = "INSERT INTO vendor_contacts " + //the all important space after the table name
                    "VALUES(" 
                    + vendor_id + "," 
                    + "'" + vendor_last_name + "'" + ","
                    + "'" + vendor_first_name + "'" + ","
                    + "'" + vendor_email + "'"
                    + ")";

                command = "INSERT INTO vendor_contacts VALUES(:Id, :l_name, :f_name, :email)"; //prepared statement

                OracleCommand cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add( new OracleParameter("Id", Convert.ToInt32(vendor_id) ) );
                cmd.Parameters.Add(new OracleParameter("l_name", vendor_last_name));
                cmd.Parameters.Add(new OracleParameter("f_name", vendor_first_name));
                cmd.Parameters.Add(new OracleParameter("email", vendor_email));

                rows = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException excep)
            {
                lbl_server_message.Text = excep.Message;
            }
            finally
            {
                lbl_server_message.Text += Convert.ToString(rows) + " rows affected";
            }
        }

        protected void btn_update_vendor_contact_Click(object sender, EventArgs e)
        {
            string vendor_id = txt_vendor_id.Text;
            string vendor_last_name = txt_vendor_last_name.Text;
            string vendor_first_name = txt_vendor_first_name.Text;
            string vendor_email = txt_vendor_email.Text;

            int rows = 0;
            try
            {
                conn.Open();

                string command = "UPDATE vendor_contacts SET last_name = '" + vendor_last_name + "', first_name = '" + vendor_first_name + "', vendor_email = '" + vendor_email + "' WHERE vendor_id  = " + vendor_id;
                command = String.Format("UPDATE vendor_contacts SET last_name = '{0}', first_name = '{1}', vendor_email = '{2}' WHERE vendor_id = {3}",
                    vendor_last_name,
                    vendor_first_name,
                    vendor_email,
                    vendor_id
                    );

                command = "UPDATE vendor_contacts " +
                    "SET last_name = :l_name, first_name = :f_name, vendor_email = :v_email " +
                    "WHERE vendor_id = :v_id";

                OracleCommand cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add(new OracleParameter("l_name", vendor_last_name));
                cmd.Parameters.Add(new OracleParameter("f_name", vendor_first_name));
                cmd.Parameters.Add(new OracleParameter("v_email", vendor_email));
                cmd.Parameters.Add(new OracleParameter("v_id", Convert.ToInt32(vendor_id) ));

                rows = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException except)
            {
                lbl_server_message.Text += except.Message;
            }
            finally
            {
                lbl_server_message.Text += " " + Convert.ToString(rows) + " rows updated.";
            }
        }

        protected void btn_delete_vendor_contact_Click(object sender, EventArgs e)
        {
            string vendor_id = txt_vendor_id.Text;
            string command = String.Format("DELETE FROM vendor_contacts WHERE vendor_id = {0}", vendor_id);
            command = "DELETE FROM vendor_contacts WHERE vendor_id = :v_id";

            int rows = 0;
            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add(new OracleParameter("v_id", Convert.ToInt32(vendor_id)));
                rows = cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch(OracleException ex)
            {
                lbl_server_message.Text = ex.Message;
            }
            finally
            {
                lbl_server_message.Text = Convert.ToString(rows) + " rows deleted";
            }
        }

        public static string OracleConnString(string host, string port, string servicename, string user, string pass)
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