using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.DatabaseManagers.Records;

namespace WCFService.DatabaseManagers
{
    public class UsersManager : BaseDatabaseManager
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

        public void Login(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Users 
                                    SET logged = @logged
                                    WHERE id = @_id";

            SqlParameter _id = new SqlParameter();
            _id.ParameterName = "@id";
            _id.SqlDbType = System.Data.SqlDbType.Int;
            _id.Direction = System.Data.ParameterDirection.Input;
            _id.Value = id;
            command.Parameters.Add(_id);

            SqlParameter logged = new SqlParameter();
            logged.ParameterName = "@logged";
            logged.SqlDbType = System.Data.SqlDbType.Bit;
            logged.Direction = System.Data.ParameterDirection.Input;
            logged.Value = 1;
            command.Parameters.Add(logged);

            command.Connection = getConnection();

            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void Logout(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Users 
                                    SET logged = @logged
                                    WHERE id = @_id";

            SqlParameter _id = new SqlParameter();
            _id.ParameterName = "@id";
            _id.SqlDbType = System.Data.SqlDbType.Int;
            _id.Direction = System.Data.ParameterDirection.Input;
            _id.Value = id;
            command.Parameters.Add(_id);

            SqlParameter logged = new SqlParameter();
            logged.ParameterName = "@logged";
            logged.SqlDbType = System.Data.SqlDbType.Bit;
            logged.Direction = System.Data.ParameterDirection.Input;
            logged.Value = 0;
            command.Parameters.Add(logged);

            command.Connection = getConnection();

            command.ExecuteNonQuery();
            command.Connection.Close();
        }

    }
}