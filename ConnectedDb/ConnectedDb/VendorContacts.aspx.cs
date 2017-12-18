using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client; //include oracle library
using ConnectedDb.Models;

namespace ConnectedDb
{
    public partial class VendorContacts : System.Web.UI.Page
    {
        static string host = "calvin.humber.ca";
        static string port = "1521";
        static string sid = "grok";
        static string user = LoginOracle.username;
        static string password = LoginOracle.password;
        static string connectionString = OracleConnString(host, port, sid, user, password);
        static OracleConnection conn = new OracleConnection(connectionString); //conn.ConnectionString =
       
        protected void Page_Load(object sender, EventArgs e)
        {
            list_vendor_contacts.InnerHtml = "";
            //Query
            string query = "SELECT vendor_id AS id, first_name AS fn FROM vendor_contacts";

            try
            {
                //open connection
                conn.Open();

                OracleCommand cmd = new OracleCommand(query, conn);
                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list_vendor_contacts.InnerHtml += "<li>" + reader["id"] + "</li>";
                    list_vendor_contacts.InnerHtml += "<li>" + reader["fn"] + "</li>";
                }

                reader.Close();
                cmd.Dispose();
                //close connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                if (ex.Message.Contains("ORA-01017"))
                {
                    lbl_db_error.Text = "login denied";
                }
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

        protected void btn_add_vc_Click(object sender, EventArgs e)
        {
            string command = "INSERT INTO vendor_contacts VALUES(200, 'Doe', 'John', 'johnny@doe.com')";
            command = String.Format("INSERT INTO vendor_contacts VALUES({0}, '{1}', '{2}', '{3}')",
                txt_id.Text,
                txt_last_name.Text,
                txt_first_name.Text,
                txt_email.Text
                );

            command = "INSERT INTO vendor_contacts (vendor_id, last_name, first_name) VALUES(:id, :l_name, :f_name)";

            try
            {
                conn.Open(); //open

                OracleCommand cmd = new OracleCommand(command, conn); //command object with sql command and connection
                cmd.Parameters.Add(new OracleParameter("id", Convert.ToInt32(txt_id.Text)));
                cmd.Parameters.Add(new OracleParameter("l_name", txt_last_name.Text));
                cmd.Parameters.Add(new OracleParameter("f_name", txt_first_name.Text));

                int rows = cmd.ExecuteNonQuery(); //executing the command on the connection
                lbl_rows_affected.Text = Convert.ToString(rows) + " rows inserted"; //Output to page number of rows inserted

                conn.Close(); //close
            }
            catch(OracleException ex)
            {
                if (ex.Message.Contains("ORA-00001"))
                {
                    lbl_db_error.Text = "Vendor Id already in use or email already in use";
                }
                else
                {
                    lbl_db_error.Text = ex.Message;
                }
            }
        }

        protected void btn_update_vc_Click(object sender, EventArgs e)
        {
            string command = "UPDATE vendor_contacts SET last_name = 'S', first_name = 'L' WHERE vendor_id = 100";
            command = String.Format("UPDATE vendor_contacts SET last_name = '{0}', first_name = '{1}' WHERE vendor_id = {2}",
                txt_last_name.Text,
                txt_first_name.Text,
                txt_id.Text
                );

            command = "UPDATE vendor_contacts SET last_name = :l_name, first_name = :f_name WHERE vendor_id = :id";

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add(new OracleParameter("f_name", txt_first_name.Text));
                cmd.Parameters.Add(new OracleParameter("l_name", txt_last_name.Text));
                cmd.Parameters.Add(new OracleParameter("id", Convert.ToInt32(txt_id.Text) ));

                int rows = cmd.ExecuteNonQuery();
                lbl_rows_affected.Text = Convert.ToString(rows) + " rows updated";

                conn.Close();
            }
            catch(OracleException ex)
            {
                lbl_db_error.Text = ex.Message;
            }
        }

        protected void btn_delete_vc_Click(object sender, EventArgs e)
        {
            string command = "DELETE FROM vendor_contacts WHERE vendor_id = 100";
            command = String.Format("DELETE FROM vendor_contacts WHERE vendor_id = {0}", txt_id.Text);
            command = "DELETE FROM vendor_contacts WHERE vendor_id = :id"; //Prepared statement

            try
            {
                conn.Open();

                OracleCommand cmd = new OracleCommand(command, conn);
                //Add value to parameter
                cmd.Parameters.Add(new OracleParameter("id", Convert.ToInt32(txt_id.Text)));

                int rows_deleted = cmd.ExecuteNonQuery();
                lbl_rows_affected.Text = Convert.ToString(rows_deleted) + " rows deleted";

                conn.Close();
            }
            catch(OracleException ex)
            {
                lbl_db_error.Text = ex.Message;
            }
        }
    }
}