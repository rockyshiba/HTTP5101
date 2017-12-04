using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NotTwitter.Models;

namespace NotTwitter
{
    public partial class Register : System.Web.UI.Page
    {
        private bool Valid_Page;

        protected void Page_Load(object sender, EventArgs e)
        {
            Validate_Register_Page();
        }

        private void Validate_Register_Page()
        {

        }

        protected void btn_post_submit_Click(object sender, EventArgs e)
        {
            //assignment
            Post post = new Post();
            post.Name = txt_post_author.Text;
            post.Body = txt_post_body.Text;

            //retrievals
            if (post.isValid())
            {
                lbl_post_author_server.Text = post.Name;
                lbl_post_body_server.Text = post.Body;
                post.Count_Post();
                lbl_post_count.Text = post.Count;
                lbl_post_date.Text = post.Date;
            }
            else
            {
                lbl_post_body_server.Text = "post invalid";
            }
        }
    }
}