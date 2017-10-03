using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class Lists : System.Web.UI.Page
    {

        List<string> names = new List<string>(new string[] { "Aron", "Bob", "Carmine", "David" });
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //foreach loop
            foreach(string item in names)
            {
                name_output.InnerHtml += "<li>" + item + "</li>";
            }

            var names_reversed = from name_item in names
                                 orderby name_item descending
                                 select name_item;

            foreach(string item in names_reversed)
            {
                name_output.InnerHtml += "<li>" + item + "</li>";
            }
        }

        /// <summary>
        /// When user types in search box, let user know if the value they provided matches a known value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void search_box_TextChanged(object sender, EventArgs e)
        {
            //Grab user's search term from textbox
            string user_search_term = search_box.Text;

            //Check if user's search term matches an existing name
            if(names.Contains(user_search_term))
            {
                //Let user know name has been found
                search_response.Text = "Name found";
            }

            foreach(string item in names)
            {
                if(item.ToLower() == user_search_term.ToLower()) //compare both sides in the same case
                {
                    search_response.Text = "Name found using foreach loop";
                }
            }
        }
    }
}