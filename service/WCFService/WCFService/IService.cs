﻿using System;
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
        [FaultContract(typeof(ServiceData))]
        bool CanLogin(string username, string password);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void InsertUser(UserRecord record);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void Login(string username);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void Logout(string username);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void UpdateUser(string token, string username, string password, string newUsername, string newPassword);

        //Persons
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        List<PersonRecord> SelectAllPerson(string token);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        PersonRecord SelectPersonById(string token, int id);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        int SelectPersonId(string token, string name);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void InsertPerson(string token, PersonRecord record);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void UpdatePerson(string token, PersonRecord record);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void RemovePerson(string token, int id);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void generatePersons(string token, int numberOfPersons, bool dropFirst);

        //Parents
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        List<ParentRecord> SelectAllParent(string token);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        int SelectParentId(string token, string name);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void InsertParent(string token, ParentRecord record);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void InsertPersonParent(string token, int person_id, int parent_id);

        //Jobs
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        List<JobRecord> SelectAllJobs(string token);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void InsertJob(string token, string workplace_name, string job, string description);

        //Refresh
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        bool NeedRefresh(DateTime lastRefresh);

        //Token
        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        string GetToken();

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        bool Identification(string token);

        [OperationContract]
        [FaultContract(typeof(ServiceData))]
        void DeleteToken(string token);
    }

    [DataContract]
    public class ServiceData
    {
        [DataMember]
        public bool Result { get; set; }
        [DataMember]
        public string ErrorMessage { get; set; }
        [DataMember]
        public string ErrorDetails { get; set; }
    }
}
