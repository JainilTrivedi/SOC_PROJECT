using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;


namespace HomeLibrary
{
    public interface IHome
    {
        [OperationContract]
        DataSet GetHouses();

        [OperationContract]
        Home getHome(string feature,int limit);

        [OperationContract]
        int RemoveHome(int id);
        [OperationContract]
        int AddHome(Home home);
    }
}
