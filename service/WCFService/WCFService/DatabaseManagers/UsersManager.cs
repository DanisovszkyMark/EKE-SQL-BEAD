using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.DatabaseManagers.Records;
using WCFService.Exceptions;

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

            try { command.Connection = getConnection(); }
            catch (Exception e)
            {
                string message = e.Message;
                throw new DatabaseConnectionException();
            }

            SqlDataReader reader;

            try { reader = command.ExecuteReader(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }

            try
            {
                while (reader.Read())
                {
                    UserRecord nextRecord = new UserRecord(reader["username"].ToString());
                    nextRecord.Password = reader["password"].ToString();
                    nextRecord.Logged = Boolean.Parse(reader["logged"].ToString());
                    records.Add(nextRecord);
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }
            return records;
        }

        public void Login(string username)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Users 
                                    SET logged = @logged
                                    WHERE username = @_username";

            SqlParameter _username = new SqlParameter();
            _username.ParameterName = "@_username";
            _username.SqlDbType = System.Data.SqlDbType.VarChar;
            _username.Direction = System.Data.ParameterDirection.Input;
            _username.Value = username;
            command.Parameters.Add(_username);

            SqlParameter logged = new SqlParameter();
            logged.ParameterName = "@logged";
            logged.SqlDbType = System.Data.SqlDbType.Bit;
            logged.Direction = System.Data.ParameterDirection.Input;
            logged.Value = 1;
            command.Parameters.Add(logged);

            try { command.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { command.ExecuteNonQuery(); }
            catch(Exception)
            {
                throw new DatabaseCommandTextException();
            }
            command.Connection.Close();
        }

        public void Logout(string username)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Users 
                                    SET logged = @logged
                                    WHERE username = @_username";

            SqlParameter _username = new SqlParameter();
            _username.ParameterName = "@_username";
            _username.SqlDbType = System.Data.SqlDbType.VarChar;
            _username.Direction = System.Data.ParameterDirection.Input;
            _username.Value = username;
            command.Parameters.Add(_username);

            SqlParameter logged = new SqlParameter();
            logged.ParameterName = "@logged";
            logged.SqlDbType = System.Data.SqlDbType.Bit;
            logged.Direction = System.Data.ParameterDirection.Input;
            logged.Value = 0;
            command.Parameters.Add(logged);

            try { command.Connection = getConnection(); }
            catch(Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { command.ExecuteNonQuery(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }

            command.Connection.Close();
        }

    }
}