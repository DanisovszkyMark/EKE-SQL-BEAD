using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using WCFService.Exceptions;

namespace WCFService.DatabaseManagers
{
    public class TokensManager : BaseDatabaseManager
    {
        public bool Identification(string token)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "Identification";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@token", token);

            var returnParameter = cmd.Parameters.Add("@ReturnVal", SqlDbType.Int);
            returnParameter.Direction = ParameterDirection.ReturnValue;

            try { cmd.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }
            var value = returnParameter.Value;
            return Convert.ToBoolean(returnParameter.Value);
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

            try
            {
                Insert(builder.ToString());
            }
            catch (DatabaseConnectionException e)
            {
                throw e;
            }
            catch (DatabaseParameterException e)
            {
                throw e;
            }

            return builder.ToString();
        }

        private void Insert(string token)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertToken";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@token", token);

            try { cmd.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }
        }

        public void Delete(string token)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeleteToken";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@token", token);

            try { cmd.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { cmd.ExecuteNonQuery(); }
            catch (Exception)
            {
                throw new DatabaseCommandTextException();
            }
        }
    }
}