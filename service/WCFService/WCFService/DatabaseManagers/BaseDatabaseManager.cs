using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WCFService.DatabaseManagers
{
    public class BaseDatabaseManager
    {
        protected SqlConnection getConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["EKE-DB"].ConnectionString;
            connection.Open();

            return connection;
        }

        protected BaseDatabaseManager()
        {
        }
    }
}