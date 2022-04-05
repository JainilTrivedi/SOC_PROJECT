using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference1;

namespace HomeAndUserClient
{
    public partial class Login : System.Web.UI.Page
    {
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient("BasicHttpBinding_IUserService");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Request.QueryString["error"]) == 1)
            {
                Label1.ForeColor = System.Drawing.Color.Red;
                Label1.Text = "User with this username or email already exists!! ";
            }
        }

        protected void LoggedIn_Click(object sender, EventArgs e)
        {
            string userName = uname.Text;
            string password = pass.Text;
            User u = client.LogInUser(userName, password);
            if (u.IsAdmin == true)
            {
                Session["isAdmin"] = "true";
            }
            else
            {
                Session["isAdmin"] = "false";
            }
            
            Session["userId"] = u.userId;
            if (u.userId == -1)
            {
                Response.Redirect("~/Login.aspx?error=1");
            }
            Session["userName"] = u.Name;
            Session["userEmail"] = u.Email;
            if (u.IsAdmin)
            {
                Response.Redirect("~/AdminPage.aspx");
            }
            Response.Redirect("~/HomePage.aspx");
        }
    }
}