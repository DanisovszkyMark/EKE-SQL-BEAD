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
            List<PersonRecord> SelectAllPerson(string token);

            [OperationContract]
            PersonRecord SelectPersonById(string token, int id);

            [OperationContract]
            void InsertPerson(string token, PersonRecord record);

            [OperationContract]
            void UpdatePerson(string token, PersonRecord record);

            [OperationContract]
            void RemovePerson(string token, int id);

        //Refresh
            [OperationContract]
            bool NeedRefresh(DateTime lastRefresh);

        //Token
            [OperationContract]
            string GetToken();

            [OperationContract]
            bool Identification(string token);

            [OperationContract]
            void DeleteToken(string token);
    }
}
