﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.DatabaseManagers;
using WCFService.DatabaseManagers.Records;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        private UsersManager usersManager = new UsersManager();
        private PersonsManager personsManager = new PersonsManager();
        private RefreshManager refreshManager = new RefreshManager();
        private TokensManager tokenManager = new TokensManager();

        public List<UserRecord> SelectAllUser()
        {
            return usersManager.Select();
        }

        public void InsertUser(UserRecord record)
        {
            throw new NotImplementedException();
        }

        public void Login(string username)
        {
            usersManager.Login(username);
        }

        public void Logout(string username)
        {
            usersManager.Logout(username);
        }

        public List<PersonRecord> SelectAllPerson(string token)
        {
            if (Identification(token)) return personsManager.Select();
            else return null;
        }

        public PersonRecord SelectPersonById(string token, int id)
        {
            if (Identification(token)) return personsManager.Select(id);
            else return null;
        }

        public void InsertPerson(string token, PersonRecord record)
        {
            if (Identification(token))
            {
                personsManager.Insert(record);
                refreshManager.UpdateLastTime(DateTime.Now);
            }
        }

        public void UpdatePerson(string token, PersonRecord record)
        {
            if (Identification(token))
            {
                personsManager.Update(record);
                refreshManager.UpdateLastTime(DateTime.Now);
            }
        }

        public void RemovePerson(string token, int id)
        {
            if (Identification(token))
            {
                personsManager.Delete(id);
                refreshManager.UpdateLastTime(DateTime.Now);
            }
        }

        public bool NeedRefresh(DateTime lastRefresh)
        {
            if (lastRefresh < LastModify().Time) return true;
            return false;
        }

        private RefreshRecord LastModify()
        {
            return refreshManager.lastRefresh();
        }

        public string GetToken()
        {
            return tokenManager.GetToken();
        }

        public bool Identification(string token)
        {
            return tokenManager.Identification(token);
        }

        public void DeleteToken(string token)
        {
            tokenManager.Delete(token);
        }
    }
}
