using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        }
    }
}