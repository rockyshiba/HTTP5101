using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OracleToDb.Models;
using Oracle.ManagedDataAccess.Client;

namespace OracleToDb
{
    public partial class TermsPage : System.Web.UI.Page
    {
        CalvinDb db = new CalvinDb();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_add_terms_Click(object sender, EventArgs e)
        {
            Terms term = new Terms();
            term.Terms_Id = 79;
            term.Terms_Description = "A new terms description";
            term.Terms_Due_Days = 1000;

            try
            {
                db.Add(term);
                lbl_success_message.Text = db.Message;
            }
            catch(OracleException ex)
            {
                lbl_error_message.Text = ex.Message;
            }
        }
    }
}