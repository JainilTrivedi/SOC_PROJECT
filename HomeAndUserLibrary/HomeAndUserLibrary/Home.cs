using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace HomeAndUserLibrary
{
    public class Home
    {
        private string location;
        private int area;
        private int age;
        private int bhk;
        private float rent;

        [DataMember]
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        [DataMember]
        public int Bhk
        {
            get { return bhk; }
            set { bhk = value; }
        }
        [DataMember]
        public float Rent
        {
            get { return rent; }
            set { rent = value; }
        }
        [DataMember]
        public int Area
        {
            get { return area; }
            set { area = value; }
        }

        [DataMember]
        public string Location
        {
            get { return location; }
            set { location = value; }
        }

    }
}
