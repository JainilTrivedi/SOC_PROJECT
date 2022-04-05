using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeAndUserClient
{
    public partial class AdminPage : System.Web.UI.Page
    {
        ServiceReference2.HomeService2Client Homeclient = new ServiceReference2.HomeService2Client("BasicHttpBinding_IHomeService2");
        ServiceReference1.UserServiceClient Userclient = new ServiceReference1.UserServiceClient("BasicHttpBinding_IUserService");

        void GetAllUsers()
        {
            DataSet ds = new DataSet();
            ds = Userclient.GetUsers();
            UserDetails.DataSource = ds.Tables[0];
            UserDetails.DataBind();
        }

        void GetAllPGs()
        {
            DataSet ds = new DataSet();
            ds = Homeclient.GetHouses();
            HomeDetails.DataSource = ds.Tables[0];
            HomeDetails.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            GetAllPGs();
            GetAllUsers();
        }


        //Add PG
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AddPG.aspx");
        }

        //Delete pg  DeletePG
        protected void DeletePG(object sender, EventArgs e)
        {
            
            LinkButton btn = (LinkButton)sender;
            int id = Int32.Parse(btn.CommandArgument);
            int t = Homeclient.RemoveHome(id);
            if (t == 0)
            {
                Label3.ForeColor = System.Drawing.Color.Red;
                Label3.Text = "Could Not delete, Pls try again";
            }
            else
            {
                GetAllPGs();
            }
        }

        //Update pg
        protected void UpdatePG(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int id = Int32.Parse(btn.CommandArgument);
            Response.Redirect("~/UpdatePG.aspx?id="+id);
        }

        protected void UpdateUser(object sender, EventArgs e)
        {
            LinkButton btn = (LinkButton)sender;
            int id = Int32.Parse(btn.CommandArgument);
            Response.Redirect("~/UpdateUser.aspx?id="+id);
        }

        protected void DeleteUser(object sender, EventArgs e)
         {
                //Label2.Text = " Here";
                LinkButton btn = (LinkButton)sender;
                int id = Int32.Parse(btn.CommandArgument);
                int t = Userclient.DeleteUser(id);
                if(t== 0)
                {
                    Label2.ForeColor = System.Drawing.Color.Red;
                    Label2.Text = "Could not delete, Try again later.";
                }else{ 
                    GetAllUsers();
                }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("~/Login.aspx");
        }
    }
}