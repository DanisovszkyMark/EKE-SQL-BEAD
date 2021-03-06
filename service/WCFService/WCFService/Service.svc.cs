﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.DatabaseManagers;
using WCFService.DatabaseManagers.Records;
using WCFService.Exceptions;

namespace WCFService
{
    public class Service : IService
    {
        private UsersManager usersManager = new UsersManager();
        private PersonsManager personsManager = new PersonsManager();
        private RefreshManager refreshManager = new RefreshManager();
        private TokensManager tokenManager = new TokensManager();
        private JobsManager jobManager = new JobsManager();
        private ParentManager parentManager = new ParentManager();

        //Users
        public bool CanLogin(string username, string password)
        {
            try
            {
                return usersManager.CanLogin(username, password);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public void InsertUser(UserRecord record)
        {
            try
            {
                usersManager.InsertUser(record.Username, record.Password);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public void Login(string username)
        {
            try
            {
                usersManager.Login(username);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public void Logout(string username)
        {
            try
            {
                usersManager.Logout(username);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public void UpdateUser(string token, string username, string password, string newUsername, string newPassword)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    usersManager.UpdateUser(username, password, newUsername, newPassword);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
        }

        //Persons
        public List<PersonRecord> SelectAllPerson(string token)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return personsManager.Select();
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
            else return null;
        }

        public PersonRecord SelectPersonById(string token, int id)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return personsManager.Select(id);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
            else return null;
        }

        public int SelectPersonId(string token, string name)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return personsManager.SelectPersonId(name);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
            else return -1;
        }

        public void InsertPerson(string token, PersonRecord record)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try { personsManager.Insert(record); }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }

                //try
                //{
                //    refreshManager.UpdateLastTime(DateTime.Now);
                //}
                //catch (DatabaseConnectionException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
                //catch (DatabaseParameterException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
            }
        }

        public void UpdatePerson(string token, PersonRecord record)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try { personsManager.Update(record); }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }

                //try
                //{
                //    refreshManager.UpdateLastTime(DateTime.Now);
                //}
                //catch (DatabaseConnectionException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
                //catch (DatabaseParameterException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
            }
        }

        public void RemovePerson(string token, int id)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try { personsManager.Delete(id); }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }

                //try
                //{
                //    refreshManager.UpdateLastTime(DateTime.Now);
                //}
                //catch (DatabaseConnectionException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
                //catch (DatabaseParameterException e)
                //{
                //    ServiceData sd = new ServiceData();
                //    sd.ErrorMessage = e.Message;
                //    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                //}
            }
        }

        public void generatePersons(string token, int numberOfPersons, bool dropFirst)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    personsManager.GeneratePersons(numberOfPersons, dropFirst);
                    //refreshManager.UpdateLastTime(DateTime.Now);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }

            }

        }

        //Parents
        public List<ParentRecord> SelectAllParent(string token)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return parentManager.SelectAll();
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }

            return null;
        }

        public int SelectParentId(string token, string name)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return parentManager.SelectParentId(name);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }

            return -1;
        }

        public void InsertParent(string token, ParentRecord record)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    parentManager.InsertParent(record);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
        }

        public void InsertPersonParent(string token, int person_id, int parent_id)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    parentManager.InsertPersonParent(person_id, parent_id);
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }
        }

        //Jobs
        public List<JobRecord> SelectAllJobs(string token)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                try
                {
                    return jobManager.SelectAllJob();
                }
                catch (DatabaseConnectionException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseCommandTextException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
                catch (DatabaseParameterException e)
                {
                    ServiceData sd = new ServiceData();
                    sd.ErrorMessage = e.Message;
                    throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
                }
            }

            return null;
        }

        public void InsertJob(string token, string workplace_name, string job, string description)
        {
            bool ok;
            try
            {
                ok = Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }

            if (ok)
            {
                jobManager.InsertJob(workplace_name, job, description);
            }
        }

        //Refresh
        public bool NeedRefresh(DateTime lastRefresh)
        {
            try
            {
                if (lastRefresh < LastModify().Time) return true;
                return false;
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        private RefreshRecord LastModify()
        {
            return refreshManager.lastRefresh();
        }

        //Identification
        public string GetToken()
        {
            try
            {
                return tokenManager.GetToken();
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public bool Identification(string token)
        {
            try
            {
                return tokenManager.Identification(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseCommandTextException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }

        public void DeleteToken(string token)
        {
            try
            {
                tokenManager.Delete(token);
            }
            catch (DatabaseConnectionException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
            catch (DatabaseParameterException e)
            {
                ServiceData sd = new ServiceData();
                sd.ErrorMessage = e.Message;
                throw new FaultException<ServiceData>(sd, new FaultReason(sd.ErrorMessage));
            }
        }
    }
}
