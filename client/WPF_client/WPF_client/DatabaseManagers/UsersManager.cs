using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_client.DatabaseManagers.Interfaces;
using WPF_client.DatabaseManagers.Records;

namespace WPF_client.DatabaseManagers
{
    class UsersManager : BaseDatabaseManager
    {
        public List<UserRecord> Select()
        {
            List<UserRecord> records = new List<UserRecord>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT *
                                    FROM Users";
            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                UserRecord nextRecord = new UserRecord(reader["username"].ToString());
                nextRecord.Password = reader["password"].ToString();
                records.Add(nextRecord);
            }

            return records;
        }
    }
}
