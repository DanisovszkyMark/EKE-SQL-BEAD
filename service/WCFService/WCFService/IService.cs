using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.DatabaseManagers.Records;

namespace WCFService
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        List<UserRecord> SelectAllUser();

        //Regisztrációhoz
        [OperationContract]
        void InsertUser(UserRecord record);

        [OperationContract]
        List<PersonRecord> SelectAllPerson();

        [OperationContract]
        void InsertPerson(PersonRecord record);

        [OperationContract]
        bool NeedRefresh(DateTime lastRefresh);
    }
}
