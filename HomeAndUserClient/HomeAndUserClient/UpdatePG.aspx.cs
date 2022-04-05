using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference2;
namespace HomeAndUserClient
{
    public partial class UpdatePG : System.Web.UI.Page
    {
        ServiceReference2.HomeService2Client client = new ServiceReference2.HomeService2Client("BasicHttpBinding_IHomeService2");
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int gotid = Convert.ToInt32(Request.QueryString["id"]);
            if ((string)Session["isAdmin"] != "true")
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                ServiceReference2.Home home = client.getHomeWithID(gotid);
                location.Text = home.Location.ToString();
                rent.Text = home.Rent.ToString();
                Age.Text = home.Age.ToString();
                area.Text = home.Area.ToString();
                BHK.Text = home.Bhk.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int gotid = Convert.ToInt32(Request.QueryString["id"]);
            ServiceReference2.Home newHome = new ServiceReference2.Home();
            newHome.Location = location.Text;
            newHome.Area = Int32.Parse(area.Text);
            newHome.Age = Int32.Parse(Age.Text);
            newHome.Bhk = Int32.Parse(BHK.Text);
            newHome.Rent = Int32.Parse(rent.Text);
            
            int t = client.UpdateHome(gotid, newHome);
            if (t == 1)
            {
                //Label1.Text =newHome.Location+" "+ newHome.Rent +" " +newHome.Age+" ";
                Response.Redirect("~/AdminPage.aspx");
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red; Label1.Text = "Error Updating!! Try Again.";
            }
        }

        protected void location_change(object sender,EventArgs e)
        {
            location.Text = location.Text;
        }

        protected void area_change(object sender,EventArgs e)
        {
            area.Text = area.Text;
        }
        protected void Age_change(object sender, EventArgs e)
        {
            Age.Text = Age.Text;
        }
        protected void rent_change(object sender, EventArgs e)
        {
            rent.Text = rent.Text;
        }
        protected void Bhk_change(object sender, EventArgs e)
        {
            BHK.Text = BHK.Text;
        }
    }
}