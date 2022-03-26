using HomeAndUserClient.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HomeAndUserClient
{
    public partial class SignUp : System.Web.UI.Page
    {
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient("BasicHttpBinding_IUserService");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = Uname.Text;
            u.Email = email.Text;
            u.Password = pass.Text;
            int t = client.AddUser(u);
            if (t == 1)
            {
                Label1.ForeColor = System.Drawing.Color.Green;
                Label1.Text = "Signed In Succefully!!";
            }
            else
            {
                Label1.Text = "Error Signin In, Try agin :(";
            }
        }
    }
}