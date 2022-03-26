using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeAndUserClient
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Text = "Id: " + Session["userId"]+" \n "+"Name: "+Session["userName"];
        }
    }
}