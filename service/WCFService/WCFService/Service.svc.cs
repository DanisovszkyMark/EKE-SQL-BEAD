using System;
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

        //Users
            public List<UserRecord> SelectAllUser()
            {
                try
                {
                    return usersManager.Select();
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
                throw new NotImplementedException();
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

                        try
                        {
                            refreshManager.UpdateLastTime(DateTime.Now);
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

                    try
                    {
                        refreshManager.UpdateLastTime(DateTime.Now);
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

                    try
                    {
                        refreshManager.UpdateLastTime(DateTime.Now);
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
