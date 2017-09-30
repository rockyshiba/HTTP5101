using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class Looping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //array of countries
            string[] countries = new string[] { "Canada", "USA", "Mexico"};

            //For loop
            for(int i = countries.Length - 1; i >= 0; i--)
            {
                //countries_list.InnerHtml = countries[countries.Length - 1];
                countries_list.InnerHtml += "<li>" + countries[i] + "</li>";
            }
        }
    }
}