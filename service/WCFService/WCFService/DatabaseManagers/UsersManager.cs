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
        public bool CanLogin(string username, string password)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Users 
                                    WHERE username = @_username AND password = @_password";

            SqlParameter _username = new SqlParameter();
            _username.ParameterName = "@_username";
            _username.Value = username;
            _username.Direction = System.Data.ParameterDirection.Input;
            _username.DbType = System.Data.DbType.String;
            command.Parameters.Add(_username);

            SqlParameter _password = new SqlParameter();
            _password.ParameterName = "@_password";
            _password.Value = password;
            _password.Direction = System.Data.ParameterDirection.Input;
            _password.DbType = System.Data.DbType.String;
            command.Parameters.Add(_password);

            try { command.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            SqlDataReader reader;

            try { reader = command.ExecuteReader(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }

            int count = 0;

            try
            {
                if (reader.Read())
                {
                    count++;
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return count == 1 ? true : false;
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