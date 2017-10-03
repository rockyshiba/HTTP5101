using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class FizzBuzz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Display 1 to 100
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0) //if a number is divisible by 3
                {
                    fizz_buzz.InnerHtml += "<li>fizzbuzz</li>";
                }
                else if(i % 5 == 0) //if a number is divisible by 5
                {
                    fizz_buzz.InnerHtml += "<li>buzz</li>";
                }
                else if (i % 3 == 0) //if a number is divisible by both
                {
                    fizz_buzz.InnerHtml += "<li>fizz</li>";
                }
                else
                {
                    fizz_buzz.InnerHtml += "<li>" + i + "</li>";
                }
            }
        }
    }
}