using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class If : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Clicking this button will check user input if a number is odd or even
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void user_button_click(object sender, EventArgs e)
        {
            //Grab user input
            int user_number;

            //Check if user provided a number
            if (int.TryParse(user_input_textbox.Text, out user_number))
            {
                //TryParse will take user_inputer_textbox and convert that to int.
                //TryParse will return true if the conversion is successful
                //TryParse will return false if the conversion was not successful

                //Check if number is odd or even
                if (user_number % 2 != 0)
                {
                    output.InnerHtml = "Number is odd";
                }
                else
                {
                    output.InnerHtml = "Number id even";
                }
            }
            else
            {
                output.InnerHtml = "A number was not provided";
            }
        }
    }
}