using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using records.Models;
using Oracle.ManagedDataAccess.Client;

namespace records
{
    public partial class Terms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TermsDb termsDb = new TermsDb();
            List<TermsDb> terms = termsDb.GetAll();

            //Webforms does not support the manipulation of a typical HTML table from C#. 
            //asp:Table must be used instead. In these situations, a reference to an asp table must be read instead.
            //For a framework this isn't ideal since HTML should be standard across frameworks.
            /*foreach(TermsDb item in terms)
            {
                terms_table.InnerHtml += String.Format(
                    "<tr><td>{0}</td><td>{1}</td><td>{2}</td></tr>", item.Terms_Id, item.Terms_Description, item.Terms_Due_Days
                    );
            }*/

            //Adding rows to a table in webforms: https://msdn.microsoft.com/en-us/library/7bewx260.aspx

            foreach(TermsDb item in terms)
            {
                //Create a row object
                TableRow tableRow = new TableRow();

                //Create the cells
                TableCell idCell = new TableCell();
                idCell.Text = item.Terms_Id;

                TableCell descCell = new TableCell();
                descCell.Text = item.Terms_Description;

                TableCell dueCell = new TableCell();
                dueCell.Text = item.Terms_Due_Days;

                //Add cells to the table rows
                tableRow.Cells.Add(idCell);
                tableRow.Cells.Add(descCell);
                tableRow.Cells.Add(dueCell);

                //Add row to table
                tbl_terms.Rows.Add(tableRow);
            }
        }

        protected void btn_add_terms_Click(object sender, EventArgs e)
        {
            int new_terms_id = Convert.ToInt32(txt_id.Text.Trim());
            string new_terms_description = txt_terms_description.Text.Trim();
            int new_terms_days = Convert.ToInt32(txt_terms_due_days.Text.Trim());

            TermsDb db = new TermsDb();
            if(db.Add(new_terms_id, new_terms_description, new_terms_days))
            {
                lbl_result_message.Text = "Success";
            }
            else
            {
                lbl_result_message.Text = "Fail";
            }
        }
    }
}