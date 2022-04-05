using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference1;
namespace HomeAndUserClient
{

    public partial class UpdateUser : System.Web.UI.Page
    {
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient("BasicHttpBinding_IUserService");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userId"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            if (!IsPostBack)
            {
                ServiceReference1.User user = client.GetUser(Int32.Parse(Session["userId"].ToString()));
                name.Text = user.Name;
                email.Text = user.Email;
                password.Text = user.Password;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int gotid = Int32.Parse(Session["userId"].ToString());
            User u = new User();
            u.Name = name.Text;
            u.Email = email.Text;
            u.Password = password.Text;
            int t = client.UpdateUser(gotid, u);
            if (t == 1)
            {
                Response.Redirect("~/HomePage.aspx");
            }
            else
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = " Error Updating, Try again!!";
            }
        }
    }
}