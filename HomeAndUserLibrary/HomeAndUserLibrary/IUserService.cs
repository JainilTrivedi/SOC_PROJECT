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
    public interface IUserService
    {
        [OperationContract]
        DataSet GetUsers();

        [OperationContract]
        User GetUser(int id);

        [OperationContract]
        int AddUser(User user);
        [OperationContract]
        int DeleteUser(int id);
    }
}
