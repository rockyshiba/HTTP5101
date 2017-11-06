using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using records.Models;

namespace records
{
    public partial class Test : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VendorsDb vendors = new VendorsDb();
            List<VendorsDb> list_vendors = vendors.GetAll();
            foreach(VendorsDb item in list_vendors)
            {
                vendors_list.InnerHtml += "<li>" + item.Vendor_Name + "</li>";
            }
        }
    }
}