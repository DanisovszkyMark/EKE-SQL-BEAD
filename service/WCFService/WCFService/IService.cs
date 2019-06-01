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
        //Users
        [OperationContract]
        List<UserRecord> SelectAllUser();

        [OperationContract]
        void InsertUser(UserRecord record);

        [OperationContract]
        void Login(string username);

        [OperationContract]
        void Logout(string username);

        //Persons
        [OperationContract]
        List<PersonRecord> SelectAllPerson();

        [OperationContract]
        PersonRecord SelectPersonById(int id);

        [OperationContract]
        void InsertPerson(PersonRecord record);

        [OperationContract]
        void UpdatePerson(PersonRecord record);

        [OperationContract]
        void RemovePerson(int id);

        //Refresh
        [OperationContract]
        bool NeedRefresh(DateTime lastRefresh);
    }
}
