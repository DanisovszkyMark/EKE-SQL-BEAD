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
    public class PersonsManager : BaseDatabaseManager
    {
        public List<PersonRecord> Select()
        {
            List<PersonRecord> records = new List<PersonRecord>();

            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT *
                                    FROM Persons";

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
                    PersonRecord nextRecord = new PersonRecord(int.Parse(reader["id"].ToString()));
                    nextRecord.Id = int.Parse(reader["id"].ToString());
                    nextRecord.Name = reader["name"].ToString();
                    nextRecord.Birt_day = DateTime.Parse(reader["birth_day"].ToString());
                    nextRecord.Job_id = int.Parse(reader["job_id"].ToString());
                    try
                    {
                        nextRecord.Salary = int.Parse(reader["salary"].ToString());
                    }
                    catch (Exception)
                    {
                        nextRecord.Salary = 0;
                    }
                    records.Add(nextRecord);
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }
            return records;
        }

        public PersonRecord Select(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Persons 
                                    WHERE id = @id";

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.Value = id;
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

            PersonRecord loadedRecord = new PersonRecord();

            try
            {
                if (reader.Read())
                {
                    loadedRecord = new PersonRecord();
                    loadedRecord.Id = int.Parse(reader["id"].ToString());
                    loadedRecord.Name = reader["name"].ToString();
                    loadedRecord.Birt_day = DateTime.Parse(reader["birth_day"].ToString());
                    loadedRecord.Job_id = int.Parse(reader["job_id"].ToString());
                    loadedRecord.Salary = int.Parse(reader["salary"].ToString());
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return loadedRecord;
        }

        public void Insert(PersonRecord record)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertPerson";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", record.Name);
            cmd.Parameters.AddWithValue("@birth_day", record.Birt_day);
            cmd.Parameters.AddWithValue("@job_id", record.Job_id);
            cmd.Parameters.AddWithValue("@salary", record.Salary);

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


        public void Update(PersonRecord record)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "UpdatePerson";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", record.Id);
            cmd.Parameters.AddWithValue("@name", record.Name);
            cmd.Parameters.AddWithValue("@birth_day", record.Birt_day);
            cmd.Parameters.AddWithValue("@job_id", record.Job_id);
            cmd.Parameters.AddWithValue("@salary", record.Salary);

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

        public void Delete(int id)
        {
            DeleteConnection(id);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeletePerson";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

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

        private void DeleteConnection(int id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "DeletePersonConnection";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);

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

        public void GeneratePersons(int numberOfRecords, bool dropFirst)
        {
            if (dropFirst)
            {
                List<PersonRecord> records;
                try
                {
                    records = Select();
                }
                catch (Exception)
                {
                    throw new DatabaseCommandTextException();
                }

                for (int i = 0; i < records.Count; i++)
                {
                    try
                    {
                        DeleteConnection(records[i].Id);
                        Delete(records[i].Id);
                    }
                    catch (Exception)
                    {
                        throw new DatabaseCommandTextException();
                    }
                }
            }

            for (int i = 0; i < numberOfRecords; i++)
            {
                PersonRecord r = new PersonRecord();
                r.Name = "Worker" + i;
                r.Birt_day = DateTime.Now;
                r.Job_id = 1;
                r.Salary = 100000;

                try
                {
                    Insert(r);
                }
                catch (Exception)
                {
                    throw new DatabaseCommandTextException();
                }
            }
        }
    }
}