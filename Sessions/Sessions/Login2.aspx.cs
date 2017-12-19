using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.ManagedDataAccess.Client;
using Sessions.Models;

namespace Sessions
{
    public partial class Login2 : System.Web.UI.Page
    {
        OracleConnection conn = new OracleConnection();
        string connectionString = OracleConnString("calvin.humber.ca", "1521", "grok", OracleLogin.username, OracleLogin.password);

        //Valid user
        string check_username = "richard";
        string check_password = "password";


        protected void Page_Load(object sender, EventArgs e)
        {

            //if a session variable named username has a value
            if(Session["pineapple"] != null)
            {
                //output username to page
                lbl_username.Text = Session["pineapple"].ToString();
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = connectionString;

            conn.Open();

            string query = "SELECT * FROM authorized_users WHERE LOWER(email) = LOWER(:em) AND password = :pw";
            OracleCommand cmd = new OracleCommand(query, conn);
            cmd.Parameters.Add(new OracleParameter("em", txt_username.Text));
            cmd.Parameters.Add(new OracleParameter("pw", txt_password.Text));

            OracleDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Session["pineapple"] = reader["email"].ToString();
                    Response.Redirect("login2.aspx");
                }
            }
            else
            {
                Session.Abandon();
                lbl_username.Text = "User not found";
            }

            conn.Close();
            //if user is valid, set up session variable
            /*if((txt_username.Text == check_username) && (txt_password.Text == check_password))
            {
                Session["pineapple"] = check_username;
            }*/
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
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