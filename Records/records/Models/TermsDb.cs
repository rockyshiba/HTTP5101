using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;

namespace records.Models
{
    public class TermsDb : CalvinDb
    {
        //Properties
        private string terms_id;
        private string terms_description;
        private string terms_due_days;

        //Fields
        public string Terms_Id { get { return terms_id; } }
        public string Terms_Description { get { return terms_description; } }
        public string Terms_Due_Days { get { return terms_due_days; } }

        protected List<TermsDb> terms = new List<TermsDb>();

        //Methods
        public List<TermsDb> GetAll()
        {
            string query = "SELECT * FROM terms";
            terms.Clear();

            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new OracleCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TermsDb thisTerm = new TermsDb();
                    thisTerm.terms_id = reader[0].ToString();
                    thisTerm.terms_description = reader["terms_description"].ToString();
                    thisTerm.terms_due_days = reader[2].ToString();

                    terms.Add(thisTerm);
                }
                reader.Close();
                conn.Close();
            }
            catch (OracleException exc)
            {
                TermsDb exceptionTerm = new TermsDb
                {
                    //Another way to assign values to a new C# class object
                    terms_id = exc.ToString(),
                    terms_description = exc.ToString(),
                    terms_due_days = exc.ToString()
                };

                terms.Add(exceptionTerm);
            }

            return terms;
        }

        public bool Add(int id, string description, int days)
        {
            string command = "INSERT INTO terms (terms_id, terms_description, terms_due_days)" +
                "VALUES (:Id, :Description, :numDays)";

            OracleConnection conn = new OracleConnection(connectionString);

            try
            {
                conn.Open();
                cmd = new OracleCommand(command, conn);
                cmd.Parameters.Add(new OracleParameter("Id", id));
                cmd.Parameters.Add(new OracleParameter("Description", description));
                cmd.Parameters.Add(new OracleParameter("numDays", days));

                int rowsInserted = cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(OracleException ex)
            {
                return false;
            }
        }
    }
}