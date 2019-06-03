using System;
using System.Collections.Generic;
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
            //update where id = 1
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Refresh 
                                    SET last_modify_time = @last_modify_time
                                    WHERE id = 1";

            SqlParameter last_modify_time = new SqlParameter();
            last_modify_time.ParameterName = "@last_modify_time";
            last_modify_time.SqlDbType = System.Data.SqlDbType.DateTime;
            last_modify_time.Direction = System.Data.ParameterDirection.Input;
            last_modify_time.Value = time;
            command.Parameters.Add(last_modify_time);

            try { command.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            try { command.ExecuteNonQuery(); }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            command.Connection.Close();
        }
    }
}