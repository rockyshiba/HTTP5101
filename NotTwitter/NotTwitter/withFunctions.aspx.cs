using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NotTwitter
{
    public partial class withFunctions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_chirp_Click(object sender, EventArgs e)
        {
            //Instead of processing a post here, where code is likely to change, the processing is done elsewhere in a function
            lbl_chirp.Text = Post_Chirp(txt_chirp.Text);
        }

        public string Post_Chirp(string post)
        {
            //Here's the same example but all the logic that went into processing a post is inside this function definition.
            //This function declared that it's going to return a string so in order for this particular function to work, the logic will have to end up returning a string
            int char_limit = 10;

            if(post.Length <= char_limit)
            {
                return post + ", count: " + post.Length.ToString();
            }
            else
            {
                return "Too many characters";
            }
        }
    }
}