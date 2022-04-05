using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeAndUserClient
{
    public partial class AddPG : System.Web.UI.Page
    {
        ServiceReference2.HomeService2Client client = new ServiceReference2.HomeService2Client("BasicHttpBinding_IHomeService2");
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)Session["isAdmin"] == "false" || Session["userId"]==null)
            {
                Response.Redirect("~/Login.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference2.Home newHome = new ServiceReference2.Home();
            newHome.Location = TextBox1.Text;
            newHome.Area = Int32.Parse(TextBox2.Text);
            newHome.Age = Int32.Parse(TextBox3.Text);
            newHome.Bhk = Int32.Parse(TextBox4.Text);
            newHome.Rent = Int32.Parse(TextBox5.Text);

            int t = client.AddHome(newHome);
            if (t == 1)
            {
                Response.Redirect("~/AdminPage.aspx");
            }
            else
            {
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "Could Not add, Try again";
            }

        }
    }
}