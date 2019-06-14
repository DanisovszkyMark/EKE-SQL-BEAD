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
                    nextRecord.WorkplaceName = reader["workplace_name"].ToString();
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

        public void InsertJob(string workplace_name, string job, string description)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertJob";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@workplace_name", workplace_name);
            cmd.Parameters.AddWithValue("@job", job);
            cmd.Parameters.AddWithValue("@description", description);

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