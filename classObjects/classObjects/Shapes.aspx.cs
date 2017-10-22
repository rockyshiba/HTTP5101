using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using classObjects.Classes; //Don't forget to include your classes

namespace classObjects
{
    public partial class Shapes : System.Web.UI.Page
    {
        //Declaring new instances of shapes
        Circle circle1 = new Circle();
        Triangle triangle1 = new Triangle();

        protected void Page_Load(object sender, EventArgs e)
        {
            result.Text = "Click on any button to calculate";
        }

        protected void btn_circle_Click(object sender, EventArgs e)
        {
            circle1.Radius = Convert.ToDouble(txt_radius.Text);
            result.Text = Convert.ToString(circle1.Area());
        }
    }
}