using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sept26
{
    public partial class stringArray : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string city = "London";
            string[] cities_list = new string[] { "London", "Peterborough", "Hamilton" };

            //ToCharArray takes a string and makes each character a member of an array
            char[] city_to_array = city.ToCharArray();

            //Loop over the array
            for (int i = 0; i <= cities_list.Length - 1; i++)
            {
                //Replace o with e
                //if(city_to_array[i] == 'o') //chars are enclosed with single quotes
                //{
                //    city_to_array[i] = 'e';
                //}

                //Take each city and convert that into an array
                char[] city_array = City_To_Array(cities_list[i]);

                //Loop over city_array
                for (int ci = 0; ci <= city_array.Length - 1; ci++)
                {
                    cities.InnerHtml += "<li>" + city_array[ci] + "</li>";
                }

                //Display each member of the string as a list item
                //cities.InnerHtml = cities.InnerHtml + "<li>" + city_to_array[i] + "</li>";
            }
        }

        /// <summary>
        /// Returns a city string into an array of chars
        /// </summary>
        /// <param name="city">A string value representing a city</param>
        /// <returns>A char array from city</returns>
        public char[] City_To_Array(string city)
        {
            return city.ToCharArray();
        }
    }
}