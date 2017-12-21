using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessions
{
    public partial class Login : System.Web.UI.Page
    {
        //Values to check against
        string auth_email = "lee@humber.ca";
        string auth_password = "password";

        protected void Page_Load(object sender, EventArgs e)
        {
            //Using a get variable
            lbl_get_var.Text = Request.QueryString["language"]; //This will return the value of a variable named language in the query string. It looks like this ?language=ENG where ENG would be the value. 

            //Check if session variable is set
            if (Session["email"] != null)
            {
                page_title.InnerHtml = Session["email"].ToString();
            }
        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string ck_email = txt_email.Text;
            string ck_password = txt_password.Text;

            if((ck_email == auth_email) && (ck_password == auth_password))
            {
                Session["email"] = ck_email;
                Response.Redirect("authorized.aspx");
            }
        }
    }
}