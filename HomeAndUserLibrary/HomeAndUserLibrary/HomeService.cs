using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAndUserLibrary
{
    public class HomeService : IHomeService2
    {
        static string con_str = @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = new SqlConnection(con_str);
       

        //Read
        DataSet IHomeService2.GetHouses()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * from Home", con_str);
            DataSet ds = new DataSet();
            da.Fill(ds, "home");
            return ds;
        }

        public Home getHomeWithID(int id)
        {
            Home home = new Home();
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                );
            SqlCommand cmd = cnn.CreateCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT   * FROM Home WHERE Id = @id";
            SqlParameter param = new SqlParameter("@id", id);
            cmd.Parameters.Add(param);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
               home.Id = dr.GetInt32(0);
               home.Location = dr.GetString(1);
                home.Area = dr.GetInt32(2);
                home.Age = dr.GetInt32(3);
                home.Bhk = dr.GetInt32(4);
                home.Rent=dr.GetInt32(5);
            }
            dr.Close();
            cnn.Close();
            return home;
        }
        //Give some thought
        //Read
        public DataSet getHome(string feature, int limit)
        {
            Console.WriteLine(feature + " " + limit);
            //SqlDataAdapter da = new SqlDataAdapter(" SELECT location,area,age,bhk,rent from Home where '" + feature + "'>'" + limit + "'", con_str);
            SqlDataAdapter da = new SqlDataAdapter(" SELECT location,area,age,bhk,rent from Home where area > 1200", con_str); // hard coded for now
            DataSet ds = new DataSet();
            da.Fill(ds, "home");
            return ds;
        }

        //Delete problem
        public int RemoveHome(int id)
        {
            SqlConnection con = new SqlConnection(con_str);
            try
            {
                using (con)
                {
                    string toDelete = "DELETE FROM Home WHERE Id='" + id + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(toDelete, con);
                    int t = (int)cmd.ExecuteNonQuery();
                    con.Close();
                    if (t == 1)
                    {
                        return 1;
                    }
                    else{
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        //Create
        public int AddHome(Home home)
        { 
            try
            {
                using (con)
                {
                    string toInsert = "INSERT INTO Home(location,area,age,bhk,rent) VALUES('" + home.Location + "','" + home.Area + "','" + home.Age + "','" + home.Bhk + "','" + home.Rent + "')";
                    SqlCommand cmd = new SqlCommand(toInsert, con);
                    con.Open();
                    int t = (int)cmd.ExecuteNonQuery();
                    if (t == 1)
                    {
                        return 1;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return 0;
        }

        //Update
        public int UpdateHome(int id,Home home)
        {
            //normal query is giving a lot of errors , so used Add parameters method :(
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE home SET location=@Location,area=@Area,age=@Age,bhk=@bhk,rent=@Rent WHERE Id =@id";
            //string toUpdate = "UPDATE home SET location=@Location,area=@Area,age=@Age,bhk=@bhk,rent=@rent WHERE Id =@id";
            cmd.Parameters.AddWithValue("@Location", home.Location);
            cmd.Parameters.AddWithValue("@Area",home.Area);
            cmd.Parameters.AddWithValue("@Age",home.Age);
            cmd.Parameters.AddWithValue("@Bhk",home.Bhk);
            cmd.Parameters.AddWithValue("@Rent",home.Rent);
            cmd.Parameters.AddWithValue("@Id",id);
            con.Open();
            int t = cmd.ExecuteNonQuery();
            if(t >= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }
    }
}
