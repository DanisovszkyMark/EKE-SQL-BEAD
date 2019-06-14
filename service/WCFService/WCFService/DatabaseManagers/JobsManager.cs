using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.DatabaseManagers.Records;
using WCFService.Exceptions;

namespace WCFService.DatabaseManagers
{
    public class JobsManager : BaseDatabaseManager
    {
        public List<JobRecord> SelectAllJob()
        {
            List<JobRecord> records = new List<JobRecord>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT *
                                    FROM Jobs";

            try { command.Connection = getConnection(); }
            catch (Exception)
            {
                throw new DatabaseConnectionException();
            }

            SqlDataReader reader;

            try { reader = command.ExecuteReader(); }
            catch
            {
                throw new DatabaseCommandTextException();
            }

            try
            {
                while (reader.Read())
                {
                    JobRecord nextRecord = new JobRecord();
                    nextRecord.Id = int.Parse(reader["id"].ToString());
                    nextRecord.WorkplaceName = reader["workpalce_name"].ToString();
                    nextRecord.Job = reader["job"].ToString();
                    nextRecord.Description = reader["description"].ToString();

                    records.Add(nextRecord);
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }
            return records;
        }
    }
}