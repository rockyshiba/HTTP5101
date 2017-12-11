using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotTwitter.Models;

namespace NotTwitter
{
    public partial class HappyBirthday : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_bday_Click(object sender, EventArgs e)
        {
            Person me = new Person();
            me.First_Name = txt_first_name.Text;
            me.Last_Name = txt_last_name.Text;
            me.Dob = Convert.ToDateTime(input_date.Value);

            int today = DateTime.Today.DayOfYear;
            if(me.Dob.DayOfYear == today)
            {
                bday_message.Text = "Happy birthday " + me.Full_Name + "!";
            }
            else
            {
                bday_message.Text = "Your birthday is " + me.Dob.Date;
            }
        }
    }
}