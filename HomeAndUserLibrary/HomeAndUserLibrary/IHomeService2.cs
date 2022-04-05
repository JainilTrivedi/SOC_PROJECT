using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ServiceModel;

namespace HomeAndUserLibrary
{
    [ServiceContract]
    public interface IHomeService2
    {
        [OperationContract]
        DataSet GetHouses();

        [OperationContract]
        DataSet getHome(string feature, int limit);

        [OperationContract]
        Home getHomeWithID(int id);

        [OperationContract]
        int RemoveHome(int id);
        [OperationContract]
        int AddHome(Home home);
        [OperationContract]
        int UpdateHome(int id,Home home);
    }
}
