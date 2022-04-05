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
        static string con_str = @"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection con = new SqlConnection(con_str);
        DataSet IUserService.GetUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "SELECT Id,name,email,isAdmin FROM UserDetails",
                @"Data Source = (localdb)\ProjectModels; Initial Catalog = SOC_PROJECT; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds,"User");
            return ds;
        }

        public User GetUser(int id)
        {
            User user = new User();
            
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT   name,email,password FROM UserDetails WHERE Id = @id";
            SqlParameter param = new SqlParameter("@id", id);
            cmd.Parameters.Add(param);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                user.Name = dr.GetString(0);
                user.Email = dr.GetString(1);
            }
            dr.Close();
            con.Close();
            return user;
        }

        public int AddUser(User u)
        {
            
            try
            {
                using (con)
                {
                    string name = u.Name;
                    string email = u.Email;
                    string password = u.Password;
                    Boolean isAdmin = false;


                    string ToCheck_uname = "Select * from UserDetails where name = @Username";
                    SqlCommand cmd_2 = new SqlCommand(ToCheck_uname, con);
                    con.Open();
                    SqlParameter param = new SqlParameter("@Username", name);
                    cmd_2.Parameters.Add(param);
                    SqlDataReader rdr = cmd_2.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        con.Close();
                        return 2;
                    }

                    rdr.Close();

                    string ToCheck_email = "Select * from UserDetails where email = @Email";
                    SqlCommand cmd_3 = new SqlCommand(ToCheck_email, con);
                    //con.Open();
                    SqlParameter param_1 = new SqlParameter("@Email", email);
                    cmd_3.Parameters.Add(param_1);
                    SqlDataReader rdr_2 = cmd_3.ExecuteReader();
                    
                    if (rdr_2.HasRows)
                    {
                        con.Close();
                        return 3;
                    }
                    rdr_2.Close();

                    string ToInsert = "INSERT INTO UserDetails(name,email,password,isAdmin) VALUES('" + name + "','" + email + "','" + password + "','" + isAdmin+ "')";
                    SqlCommand cmd = new SqlCommand(ToInsert,con);
                    //con.Open();
                    int inserted = (int)cmd.ExecuteNonQuery();
                    Console.WriteLine(inserted);
                    if(inserted == 1)
                    {
                        return 1;
                    }
                    con.Close();
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

        public User LogInUser(string uname,string password)
        {
            User u = new User();
             
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\ProjectModels;Initial Catalog=SOC_PROJECT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlCommand cmd = con.CreateCommand();
            cmd.Connection = con;
            
            cmd.CommandText = "SELECT * FROM UserDetails where password='" + password + "' and name='" + uname + "'";
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                u.userId = dr.GetInt32(0);
                u.Name = dr.GetString(1);
                u.Email = dr.GetString(2);
                u.Password = dr.GetString(3);
                u.IsAdmin = dr.GetBoolean(4);
            }
            if(u.Name == "")
            {
                u.userId = -1;
            }
            dr.Close();
            con.Close();
            return u;
        }

        public int UpdateUser(int id,User user)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "UPDATE UserDetails SET name=@name,email=@email,password=@password WHERE Id =@id";
            
            cmd.Parameters.AddWithValue("@name", user.Name);
            cmd.Parameters.AddWithValue("@email", user.Email);
            cmd.Parameters.AddWithValue("@password", user.Password);

            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            int t = cmd.ExecuteNonQuery();
            if (t >= 1)
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
