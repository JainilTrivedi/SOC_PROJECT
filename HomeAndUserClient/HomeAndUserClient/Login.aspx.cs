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
                Label1.Text = "Invalid User anme or password!";
            }
        }

        protected void LoggedIn_Click(object sender, EventArgs e)
        {
            string userName = uname.Text;
            string password = pass.Text;
            User u = client.LogInUser(userName, password);

            Session["userId"] = u.userId;
            if (u.userId == -1)
            {
                Response.Redirect("~/Login.aspx?error=1");
            }
            Session["userName"] = u.Name;
            Session["userEmail"] = u.Email;
            Response.Redirect("~/HomePage.aspx");
        }
    }
}