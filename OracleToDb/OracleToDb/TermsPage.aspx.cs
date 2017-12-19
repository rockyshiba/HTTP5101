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
            Terms t = new Terms();
            t.Terms_Id = 3;
            //t.Terms_Description = "terms";

            try
            {
                List<Terms> ts = db.Get(t);
                foreach (Terms item in ts)
                {
                    list_terms.InnerHtml += "<li>" + item.Terms_Id.ToString() + " " + item.Terms_Description + " " + item.Terms_Due_Days.ToString() + item.Vendor.Vendor_Name + "</li>";
                }
            }
            catch(OracleException ex)
            {
                lbl_error_message.Text = ex.Message;
            }
            
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

        protected void btn_update_terms_Click(object sender, EventArgs e)
        {
            Terms term = new Terms();
            term.Terms_Id = 6;
            term.Terms_Description = "Greens fields";
            term.Terms_Due_Days = 12182017;

            try
            {
                db.Update(term);
                lbl_success_message.Text = db.Message;
            }
            catch(OracleException ex)
            {
                lbl_error_message.Text = ex.Message;
            }
        }

        protected void btn_delete_term_Click(object sender, EventArgs e)
        {
            Terms term = new Terms();
            term.Terms_Id = 6;

            try
            {
                db.Delete(term);
                lbl_success_message.Text = db.Message;
            }
            catch(OracleException ex)
            {
                lbl_success_message.Text = ex.Message;
            }
        }
    }
}