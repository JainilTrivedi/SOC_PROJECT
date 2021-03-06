using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HomeAndUserLibrary
{
    [DataContract]
    public class User
    {

        private int Id;
        private string name = "";
        private string email="";
        private string password="";
        private bool isAdmin = false;

        [DataMember]
        public int userId
        {
            get { return Id; }
            set { Id = value; }
        }

        [DataMember]
        public string Name
        {
            get { return name; }    
            set { name = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public bool IsAdmin
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }
    }
}
