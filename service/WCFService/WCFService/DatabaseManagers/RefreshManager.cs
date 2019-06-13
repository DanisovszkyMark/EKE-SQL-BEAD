using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.DatabaseManagers.Records;
using WCFService.Exceptions;

namespace WCFService.DatabaseManagers
{
    public class RefreshManager : BaseDatabaseManager
    {
        public RefreshRecord lastRefresh()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Refresh 
                                    WHERE id = @id";

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = 1;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.DbType = System.Data.DbType.Int64;
            command.Parameters.Add(pId);

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

            RefreshRecord loadedRecord = new RefreshRecord();

            try
            {
                if (reader.Read())
                {
                    loadedRecord = new RefreshRecord();

                    loadedRecord.Id = int.Parse(reader["id"].ToString());
                    loadedRecord.Time = DateTime.Parse(reader["last_modify_time"].ToString());
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return loadedRecord;
        }

        public void UpdateLastTime(DateTime time)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdateLastModifyTime";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@last_modify_time", time);

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