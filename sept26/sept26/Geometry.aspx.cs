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

        /// <summary>
        /// Clicking the button with onclick="circle_button_Click"
        /// takes in the textbox with ID="radius" Text value and converts it to double to be stored in a variable called radius_var
        /// It uses the area_of_circle function (defined below) with radius_var to calculate the area of a circle which is then converted to string to be displayed as text to the label with ID="result"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void circle_button_Click(object sender, EventArgs e)
        {
            
            //get radius from input
            double radius_var = Convert.ToDouble(radius.Text);

            //Calculate area of circle
            //double circle_area = 3.14 * Math.Pow(radius_var, 2);

            //output area of circle to page
            result.Text = Convert.ToString(area_of_circle(radius_var));
        }

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

        //Areas

        /// <summary>
        /// Returns the area of a circle with the parameter rad
        /// </summary>
        /// <param name="rad"></param>
        /// <returns></returns>
        public double area_of_circle(double rad)
        {
            double area = 3.14 * Math.Pow(rad, 2);
            return area;
        }

        /// <summary>
        /// Returns the area of a sphere with the parameter rad
        /// </summary>
        /// <param name="rad"></param>
        /// <returns></returns>
        public double area_of_sphere(double rad)
        {
            double area = 4 * 3.14 * Math.Pow(rad, 2);
            area = 4 * area_of_circle(rad);
            return area;
        }

        /// <summary>
        /// Returns the area of a cylinder with two parameters, rad and hgt (radius and height)
        /// </summary>
        /// <param name="rad"></param>
        /// <param name="hgt"></param>
        /// <returns></returns>
        public double area_of_cylinder(double rad, double hgt)
        {
            double area = (2 * 3.14 * rad * hgt) + (2 * 3.14 * Math.Pow(rad, 2));
            return area;
        }
        //End areas
    }
}