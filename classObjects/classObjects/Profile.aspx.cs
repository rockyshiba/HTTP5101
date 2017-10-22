using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classObjects.Classes; //this is required to include the classes we've defined in the classes directory. Look at the statement, it's the name of this project with the name of the directory

namespace classObjects
{
    public partial class Profile : System.Web.UI.Page
    {
        //Declare a new instace of a class
        Webpage a_new_page = new Webpage();

        protected void Page_Load(object sender, EventArgs e)
        {
            a_new_page.Title = "Profile";
            a_new_page.Header = "<h1>Profile for Person</h1>";
            a_new_page.Body = "<h2>" +
                "Things that a person has" +
                "</h2>" +
                "<ul>" +
                "<li>" +
                "Name" +
                "</li>" +
                "</ul>";
            a_new_page.Footer = "&copy;Pages Inc. " +
                DateTime.Now.Year.ToString(); //This is how you display the current year. Using the already provided DateTime class, you can get date details such as Now and the Year. 
            a_new_page.Css = "header{ color: green; text-align: center; }";

            title.Text = a_new_page.Title;
            style.InnerHtml = a_new_page.Css;
            body.InnerHtml = a_new_page.Header + a_new_page.Body + a_new_page.Footer;
        }
    }
}