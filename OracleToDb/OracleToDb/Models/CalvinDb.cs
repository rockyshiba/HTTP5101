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
        public List<Terms> Get(Terms term)
        {
            List<Terms> terms = new List<Terms>();
            OracleCommand cmd;
            OracleDataReader reader;

            string query;

            if(term.Terms_Id != 0)
            {
                query = "SELECT * FROM terms t " +
                    "JOIN vendors v ON t.terms_id = v.default_terms_id " +
                    "WHERE terms_id = :id";

                conn.Open();

                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("id", term.Terms_Id));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Terms t = new Terms();
                    t.Terms_Id = Convert.ToInt32(reader["terms_id"]);
                    t.Terms_Description = reader["terms_description"].ToString();
                    t.Terms_Due_Days = Convert.ToInt32(reader["terms_due_days"]);

                    t.Vendor = new Vendors();
                    t.Vendor.Vendor_Name = reader["vendor_name"].ToString();

                    terms.Add(t);
                }

                conn.Close();

                return terms;
            }

            if (!String.IsNullOrWhiteSpace(term.Terms_Description))
            {
                query = "SELECT * FROM terms WHERE terms_description LIKE LOWER('%' || :t_desc || '%')";

                conn.Open();

                cmd = new OracleCommand(query, conn);
                cmd.Parameters.Add(new OracleParameter("t_desc", term.Terms_Description));
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Terms t_temp = new Terms();
                    t_temp.Terms_Id = Convert.ToInt32(reader["terms_id"]);
                    t_temp.Terms_Description = reader["terms_description"].ToString();
                    t_temp.Terms_Due_Days = Convert.ToInt32(reader["terms_due_days"]);

                    terms.Add(t_temp);
                }

                conn.Close();

                return terms;
            }

            query = "SELECT * FROM terms";

                conn.Open();

                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Terms t = new Terms()
                    {
                        Terms_Id = Convert.ToInt32(reader["terms_id"]),
                        Terms_Description = reader["terms_description"].ToString(),
                        Terms_Due_Days = Convert.ToInt32(reader["terms_due_days"])
                    };

                    terms.Add(t);
                }

                conn.Close();

            return terms;
        }

        public void Add(VendorContacts vc)
        {

        }

        public void Add(Terms terms)
        {
            string command = "INSERT INTO " +
                "terms VALUES(:t_id, :t_desc, :t_due_days)";
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

        public void Update(Terms term)
        {
            string command = "UPDATE terms SET terms_description = :t_desc, terms_due_days = :t_days WHERE terms_id = :id";

            conn.Open();
            OracleCommand cmd = new OracleCommand(command, conn);
            cmd.Parameters.Add(new OracleParameter("t_desc", term.Terms_Description));
            cmd.Parameters.Add(new OracleParameter("t_days", term.Terms_Due_Days));
            cmd.Parameters.Add(new OracleParameter("id", term.Terms_Id));

            int rows = cmd.ExecuteNonQuery();
            Message = Convert.ToString(rows) + " rows updated in database";

            cmd.Dispose();
            conn.Close();
        }

        public void Delete(Terms term)
        {
            string command = "DELETE FROM terms_description WHERE terms_id = :id";

            conn.Open();
            OracleCommand cmd = new OracleCommand(command, conn);
            cmd.Parameters.Add(new OracleParameter("id", term.Terms_Id));

            int rows = cmd.ExecuteNonQuery();
            Message = Convert.ToString(rows) + " rows deleted from database";

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