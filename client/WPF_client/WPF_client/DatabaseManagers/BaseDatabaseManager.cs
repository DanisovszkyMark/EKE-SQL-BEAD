using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_client.DatabaseManagers
{
    /// <summary>
    /// Ellátja az datbáziskapcsolat menedzsmentjét az app.config file alapján.
    /// </summary>
    class BaseDatabaseManager
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
