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
            for(int i = 0; i >= countries.Length -1; i++)
            {
                //countries_list.InnerHtml = countries[countries.Length - 1];
                countries_list.InnerHtml += "<li>" + countries[i] + "</li>";
            }

            //Reversed for loop
            for (int i = countries.Length - 1; i >= 0; i--)
            {
                //To start from the end of the array, we take the length of the array sbutracted by 1
                //Remember, the length of the array is the number of items in it but array indexes start at 0
                countries_list_reversed.InnerHtml += "<li>" + countries[i] + "</li>";
            }
        }
    }
}