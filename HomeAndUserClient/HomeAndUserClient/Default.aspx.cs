using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference1;

namespace HomeAndUserClient
{
    public partial class Default : System.Web.UI.Page
    {
        ServiceReference1.UserServiceClient client = new ServiceReference1.UserServiceClient("BasicHttpBinding_IUserService");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Name = uname.Text;
            u.Email= email.Text;
            u.Password=pass.Text;
            int t = client.AddUser(u);
            if (t == 1)
            {
                uname.Text = "";
                email.Text = "";
                pass.Text = " ";
                uid.Text = "";
                Label5.Text = "";
                Label6.Text = "Signed In Succefully!!";
            }
            else
            {
                Label6.Text = "Error Signin In, Try agin :(";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            uname.Text = "";
            email.Text = "";
            pass.Text = " ";
            uid.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            DataSet ds = client.GetUsers();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(uid.Text);
            uname.Text = "";
            email.Text = "";
            pass.Text = " ";
            uid.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            
            User fetchedUser = client.GetUser(userId);
            Label5.Text = "Name: "+fetchedUser.Name+"\n" +"Email: "+fetchedUser.Email;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            int userId = Int32.Parse(uid.Text);
            uname.Text = "";
            email.Text = "";
            pass.Text = " ";
            uid.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            GridView1.DataSource=null;
            GridView1.DataBind();
            
            int t = client.DeleteUser(userId);
            if (t == 1)
            {
                Label6.Text = "User Deleted";
                uid.Text = "";
            }
            else
            {
                Label6.Text = "User With UserId " + userId + " does not exist";
                uid.Text = "";
            }

        }
    }
}