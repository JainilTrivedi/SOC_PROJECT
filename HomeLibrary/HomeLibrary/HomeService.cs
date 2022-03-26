using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeLibrary
{
    public class HomeService: IHome
    {
        string con_str = @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        DataSet IHome.GetHouses()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT location,area,age,bhk,rent from Home",con_str);
            DataSet ds = new DataSet();
            da.Fill(ds,"home");
            return ds;
        }

        public Home getHome(string feature,int limit)
        {
            Home home = new Home();
            SqlConnection cnn = new SqlConnection(con_str);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = " SELECT location,area,age,bhk,rent from Home where "+ feature + "'>='" + limit;
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                home.Location = dr.GetString(0);
                home.Area = dr.GetFloat(1);
                home.Age = dr.GetInt32(2);
                home.Bhk = dr.GetInt32(3);
                home.Rent = dr.GetInt32(4);
            }
            dr.Close();
            cnn.Close();
            return home;
        }

        public int RemoveHome(int id)
        {
            SqlConnection con = new SqlConnection(con_str);
            try
            {
                using (con)
                {
                    string toDelete = "DELETE FORM Home WHERE Id='" + id + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(toDelete,con);
                    int t = (int)cmd.ExecuteNonQuery();
                    if (t == 1)
                    {
                        return 1;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        public int AddHome(Home home)
        {
            SqlConnection con   =new SqlConnection(con_str);
            try
            {
                using (con)
                {
                    string toInsert = "INSERT INTO Home(location,area,age,bhk,rent) VALUES('" + home.Location + "','" + home.Area + "','" + home.Age + "','" + home.Bhk + "','" + home.Rent + "')";
                    SqlCommand cmd = new SqlCommand(toInsert,con);
                    con.Open();
                    int t = (int)cmd.ExecuteNonQuery();
                    if (t == 1)
                    {
                        return 1;
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            return 0;
        }
    }
}
