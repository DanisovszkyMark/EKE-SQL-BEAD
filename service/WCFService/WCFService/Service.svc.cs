﻿using System;
using System.Collections.Generic;
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

        public List<UserRecord> SelectAllUser()
        {
            return usersManager.Select();
        }

        public List<PersonRecord> SelectAllPerson()
        {
            return personsManager.Select();
        }

        public List<PersonRecord> Error_Persons()
        {
            throw new NotImplementedException();
        }
    }
}