using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Authorized : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty((string)Session["email"])) //If the email session variable is not null or empty
            {
                page_heading.InnerText = "Hi " + (string)Session["email"];
                //page_heading.InnerText = Session.SessionID.ToString();
            }
            else
            {
                //Go back to login.aspx
                Response.Redirect("login.aspx");
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            //Specifically remove a session variable
            Session.Remove("email");

            //Clears all session values
            //Session.Clear();

            //Ends the session. Sessions end after a timer
            //Session.Abandon();

            Response.Redirect("login.aspx");
        }
    }
}