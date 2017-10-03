using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class whileLoop : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int counter = 10;

            while (counter > 0) //When writing while conditions, make sure the condition can be false
            {
                while_output.InnerHtml += Convert.ToString(counter);

                //Make sure in the while loop, the condition can eventually be false
                counter--;
            }

            while_output.InnerHtml += "While loop finished";
        }
    }
}