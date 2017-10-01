using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_button_Click(object sender, EventArgs e)
        { //beginning of code for login_button_Click
            string username_input = username.Text;
            username_input = username_input.Trim();

            string login_name = "Lee";

            //check if username matches login name
            if(username_input == login_name)
            {
                //Welcome the user
                server_response.Text = "Welcome";
            }
            //if user did not type anything
            else if (username_input == "" || username_input == null)
            {
                server_response.Text = "Please provide input";
                //reset the textbox to ""
                username.Text = "";
            }
            else
            {
                server_response.Text = "Access denied";
            }

        } //end of code for login_button_Click

        /// <summary>
        /// In C#, strings have a length property that returns the length of a string in a integer. 
        /// When clicking a button with onclick="length_button_Click", username_input is assigned the value of the textbox with ID="username".
        /// The variable length is assigned the value of 7.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void length_button_Click(object sender, EventArgs e)
        {
            string username_input = username.Text;
            int length = 7;

            if(username_input.Length == length)
            {
                //If the length of username_input is equal to the length variable, this block of code will be read
                server_response.Text = "Correct";
            }
            else
            {
                //If the if statement's condition was not true, this block of code will be read instead
                server_response.Text = "Guess again";
            }
        }

        public string sayHi()
        {
            return "Hi";
        }

        public double square(double num)
        {
            return Math.Pow(num, 2);
        }
    }
}