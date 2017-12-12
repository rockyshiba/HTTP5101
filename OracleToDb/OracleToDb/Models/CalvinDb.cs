using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace OracleToDb.Models
{
    public class CalvinDb
    {
        private const string host = "calvin.humber.ca";
        private const string port = "1521";
        private const string sid = "grok";
        private const string user = OracleCredentials.username;
        private const string pass = OracleCredentials.password;
        private static OracleConnection conn = new OracleConnection(OracleConnString(host, port, sid, user, pass));
        private string _message;

        //Properties
        private string connectionString { get { return OracleConnString(host, port, sid, user, pass); } }
        public string Message
        {
            get { return _message; }
            set { this._message = value; }
        }

        //Methods
        public void Add(Terms terms)
        {
            string command = "INSERT INTO terms VALUES(:t_id, :t_desc, :t_due_days)";
            conn.Open();

            OracleCommand cmd = new OracleCommand(command, conn);
            cmd.Parameters.Add(new OracleParameter("t_id", terms.Terms_Id));
            cmd.Parameters.Add(new OracleParameter("t_desc", terms.Terms_Description));
            cmd.Parameters.Add(new OracleParameter("t_due_days", terms.Terms_Due_Days));

            int rows = cmd.ExecuteNonQuery();
            Message = Convert.ToString(rows) + " rows added to database";

            cmd.Dispose();
            conn.Close();
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