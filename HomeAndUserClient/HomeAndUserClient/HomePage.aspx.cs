using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference1;
using HomeAndUserClient.ServiceReference2;
namespace HomeAndUserClient
{
    public partial class HomePage : System.Web.UI.Page
    {
        void GetAllPGList()
        {
            ServiceReference2.HomeService2Client client = new ServiceReference2.HomeService2Client("BasicHttpBinding_IHomeService2");
            DataSet ds = new DataSet();
            ds = client.GetHouses();
            UserDetails.DataSource = ds.Tables[0];
            UserDetails.DataBind();
            //usernameishere.Text = (Session["userId"].ToString());
            //usernameishere.Text = Session["userName"].ToString();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["userId"]== null)
            {
                Response.Redirect("~/Login.aspx");
            }
            GetAllPGList();
        }

        protected void SelectPG(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateUser.aspx");
        }
    }
}