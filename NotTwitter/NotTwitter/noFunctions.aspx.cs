using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotTwitter
{
    public partial class noFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_chirp_Click(object sender, EventArgs e)
        {
            int char_limit = 10;

            //Display contents of textbox in label
            string user_input = txt_chirp.Text;

            //Check if what the user entered is below or at a certain character limit. The check the length of a string use the Length property
            if(user_input.Length <= char_limit)
            {
                lbl_chirp.Text = user_input;
                //You can also display the character count like so:
                lbl_chirp.Text += " count: " + user_input.Length.ToString();
            }
            else
            {
                lbl_chirp.Text = "Too many characters";
            }
        }
    }
}