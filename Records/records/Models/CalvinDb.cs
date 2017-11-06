using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace records.Models
{
    public class CalvinDb
    {
        private string host = "calvin.humber.ca";
        private string port = "1521";
        private string sid = "grok";
        private string user = "";
        private string password = "";
        protected string connectionString { get { return OracleConnString(host, port, sid, user, password); } }

        protected OracleConnection myConnection { get { return new OracleConnection(connectionString); } }
        protected OracleCommand cmd;
        protected OracleDataReader reader;

        private string OracleConnString(string host, string port, string servicename, string user, string pass)
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