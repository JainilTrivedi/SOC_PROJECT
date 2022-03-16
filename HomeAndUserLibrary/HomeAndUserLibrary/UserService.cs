using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAndUserLibrary
{
    public class UserService:IUserService
    {
        DataSet IUserService.GetUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id,name,email FROM UserDetails",
                @"Data Source = (localdb)\ProjectModels; Initial Catalog = SOC_PROJECT; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds,"User");
            return ds;
        }

        public User GetUser(int id)
        {
            User user = new User();
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
                );
            SqlCommand cmd = cnn.CreateCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT   name,email FROM UserDetails WHERE Id = @id";
            SqlParameter param = new SqlParameter("@id", id);
            cmd.Parameters.Add(param);
            cnn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user.Name = dr.GetString(0);
                user.Email = dr.GetString(1);
            }
            dr.Close();
            cnn.Close();
            return user;
        }

        public int AddUser(User u)
        {
            SqlConnection cnn = new SqlConnection(
                @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"

            );
            try
            {
                using (cnn)
                {
                    string name = u.Name;
                    string email = u.Email;
                    string password = u.Password;
                    Boolean isAdmin = false;
                    string ToInsert = "INSERT INTO UserDetails(name,email,password,isAdmin) VALUES('" + name + "','" + email + "','" + password + "','" + isAdmin+ "')";
                    SqlCommand cmd = new SqlCommand(ToInsert,cnn);
                    cnn.Open();
                    int inserted = (int)cmd.ExecuteNonQuery();
                    if(inserted == 1)
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

        public int DeleteUser(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            try
            {
                using (con)
                {
                    string toDelete = "DELETE FROM UserDetails where Id='" + id + "'";
                    con.Open();
                    SqlCommand cmd = new SqlCommand(toDelete,con);
                    int deleted = (int)cmd.ExecuteNonQuery();
                    con.Close();
                    //int deleted = (int)cmd.ExecuteNonQuery();
                    
                    if(deleted == 1)
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
