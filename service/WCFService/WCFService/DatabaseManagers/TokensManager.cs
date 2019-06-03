using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;

namespace WCFService.DatabaseManagers
{
    public class TokensManager : BaseDatabaseManager
    {
        public bool Identification(string token)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Tokens 
                                    WHERE token = @_token";

            SqlParameter _token = new SqlParameter();
            _token.ParameterName = "@_token";
            _token.Value = token;
            _token.Direction = System.Data.ParameterDirection.Input;
            _token.DbType = System.Data.DbType.String;
            command.Parameters.Add(_token);

            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                if (token == reader["token"].ToString()) return true;
            }

            return false;
        }

        public string GetToken()
        {
            Random rnd = new Random();
            StringBuilder builder = new StringBuilder();

            string abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string nums = "0123456789";

            for (int i = 0; i < 50; i++)
            {
                if (rnd.NextDouble() < 0.7)
                {
                    builder.Append(abc[rnd.Next(abc.Length)]);
                }
                else
                {
                    builder.Append(nums[rnd.Next(nums.Length)]);
                }
            }
            //INSERT
            Insert(builder.ToString());

            return builder.ToString();
        }

        private void Insert(string token)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"INSERT INTO Tokens(token)
                                    VALUES (@_token)";
            command.Connection = getConnection();

            SqlParameter _token = new SqlParameter();
            _token.ParameterName = "@_token";
            _token.SqlDbType = System.Data.SqlDbType.Char;
            _token.Direction = System.Data.ParameterDirection.Input;
            _token.Value = token;
            command.Parameters.Add(_token);

            command.ExecuteNonQuery();
        }

        public void Delete(string token)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"DELETE FROM Tokens 
                                    WHERE token = @_token";

            SqlParameter _token = new SqlParameter();
            _token.ParameterName = "@_token";
            _token.SqlDbType = System.Data.SqlDbType.Char;
            _token.Direction = System.Data.ParameterDirection.Input;
            _token.Value = token;
            command.Parameters.Add(_token);

            command.Connection = getConnection();
            command.ExecuteNonQuery();

            command.Connection.Close();
        }
    }
}