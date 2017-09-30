using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class Geometry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void circle_button_Click(object sender, EventArgs e)
        {
            //get radius from input
            double radius_var = Convert.ToDouble(radius.Text);

            //Calculate area of circle
            //double circle_area = 3.14 * Math.Pow(radius_var, 2);

            //output area of circle to page
            result.Text = Convert.ToString(area_of_circle(radius_var));
        }

        //Areas
        public double area_of_circle(double rad)
        {
            double area = 3.14 * Math.Pow(rad, 2);
            return area;
        }

        public double area_of_sphere(double rad)
        {
            double area = 4 * 3.14 * Math.Pow(rad, 2);
            area = 4 * area_of_circle(rad);
            return area;
        }

        public double area_of_cylinder(double rad, double hgt)
        {
            double area = (2 * 3.14 * rad * hgt) + (2 * 3.14 * Math.Pow(rad, 2));
            return area;
        }
        //End areas

        protected void sphere_button_Click(object sender, EventArgs e)
        {
            //get radius from user
            double radius_var = Convert.ToDouble(radius.Text);
            //output result to page
            result.Text = Convert.ToString(area_of_sphere(radius_var));
        }

        protected void cylinder_button_Click(object sender, EventArgs e)
        {
            double radius_var;
            double height_var;
            radius_var = Convert.ToDouble(radius.Text);
            height_var = Convert.ToDouble(height.Text);

            result.Text = Convert.ToString(area_of_cylinder(radius_var, height_var));
        }
    }
}