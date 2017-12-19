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
    public partial class Homepage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection();
            conn.ConnectionString = OracleConnString("calvin.humber.ca", "1521", "grok", OracleLogin.username, OracleLogin.password);

            try
            {
                conn.Open();
                string query = "SELECT * FROM homepage WHERE lang = :lan";
                OracleCommand cmd = new OracleCommand(query, conn);

                if (Request.QueryString["language"] != null)
                {
                    string query_language = Request.QueryString["language"]; //ENG, CHN, JPN
                    cmd.Parameters.Add(new OracleParameter("lan", query_language));
                }
                else
                {
                    cmd.Parameters.Add(new OracleParameter("lan", "ENG"));
                }

                OracleDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    title.InnerText = reader["title"].ToString();
                    main.InnerText = reader["body"].ToString();
                    footer.InnerText = reader["footer"].ToString();
                }

                conn.Close();
            }
            catch(OracleException ex)
            {
                main.InnerHtml = ex.Message;
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