using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HomeAndUserClient.ServiceReference2;

namespace HomeAndUserClient
{
    
    public partial class Home : System.Web.UI.Page
    {
        ServiceReference2.HomeService2Client client = new ServiceReference2.HomeService2Client("BasicHttpBinding_IHomeService2");
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        //Get All homes
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet ds = client.GetHouses();
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
        }

        //Get all homes with specific conditions
        protected void Button2_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            DataSet ds = client.getHome("area",1201);
            GridView1.DataSource = ds.Tables[0].DefaultView;
            GridView1.DataBind();
            //string area = TextBox2.Text;
            //string location = TextBox1.Text;
            //string age = TextBox3.Text;
            //string bhk = TextBox4.Text;
            //string rent =  TextBox5.Text;
            //string feature = "area";
            //int limit = 1000;
            //ServiceReference2.Home home = client.getHome(feature, limit);
            //Label1.Text = "Location: "+home.Location.ToString() +" Age: "+home.Age + " Bhk: "+home.Bhk+" rent: "+home.Rent;

        }


        //Remove Home with id
        protected void Button3_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            int id = Int32.Parse(TextBox6.Text);
            int t = client.RemoveHome(id);
            if (t > 0)
            {
                Label1.Text = "T is " +t+"House Removed Successfully";
            }
            else
            {
                Label1.Text = "T is : "+t+ "House with id = " + id + "not found";
                Label2.Text = "Click Get All PGs for more details..";
            }
        }
        //Add
        protected void Button4_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            GridView1.DataSource = null;
            GridView1.DataBind();

            ServiceReference2.Home newHome = new ServiceReference2.Home();
            newHome.Location = TextBox1.Text;
            newHome.Area = Int32.Parse(TextBox2.Text);
            newHome.Age = Int32.Parse(TextBox3.Text);
            newHome.Bhk = Int32.Parse(TextBox4.Text);
            newHome.Rent = Int32.Parse(TextBox5.Text);

            int t = client.AddHome(newHome);
            if (t == 1)
            {
                Label1.Text = "Added";
            }
            else
            {
                Label1.Text = "Not Added";
            }
        }
        //Update
        protected void Button5_Click(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            GridView1.DataSource = null;
            GridView1.DataBind();

            ServiceReference2.Home newHome = new ServiceReference2.Home();
            newHome.Location = TextBox1.Text;
            Label2.Text = newHome.Location;
            newHome.Area = Int32.Parse(TextBox2.Text);
            newHome.Age = Int32.Parse(TextBox3.Text);
            newHome.Bhk = Int32.Parse(TextBox4.Text);
            newHome.Rent = Int32.Parse(TextBox5.Text);
            int id = Int32.Parse(TextBox6.Text);
            int t = client.UpdateHome(id, newHome);
            if (t == 1)
            {
                Label1.Text = "Updated";
            }
            else
            {
                Label1.Text = "Not";
            }
        }
    }
}