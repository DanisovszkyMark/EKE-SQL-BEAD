using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WCFService.DatabaseManagers.Records;

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
            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
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

            command.Connection = getConnection();

            SqlDataReader reader = command.ExecuteReader();
            PersonRecord loadedRecord = new PersonRecord();
            if (reader.Read())
            {
                loadedRecord = new PersonRecord();
                loadedRecord.Id = int.Parse(reader["id"].ToString());
                loadedRecord.Name = reader["name"].ToString();
                loadedRecord.Birt_day = DateTime.Parse(reader["birth_day"].ToString());
                loadedRecord.Job_id = int.Parse(reader["job_id"].ToString());
            }

            return loadedRecord;
        }

        public void Insert(PersonRecord record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"INSERT INTO Persons(name, birth_day, job_id, salary)
                                    VALUES (@name, @birth_day, @job_id, @salary)";
            command.Connection = getConnection();

            SqlParameter name = new SqlParameter();
            name.ParameterName = "@name"; 
            name.SqlDbType = System.Data.SqlDbType.VarChar;
            name.Direction = System.Data.ParameterDirection.Input; 
            name.Value = record.Name;
            command.Parameters.Add(name);

            SqlParameter birth_day = new SqlParameter();
            birth_day.ParameterName = "@birth_day";
            birth_day.SqlDbType = System.Data.SqlDbType.DateTime;
            birth_day.Direction = System.Data.ParameterDirection.Input;
            birth_day.Value = record.Birt_day;
            command.Parameters.Add(birth_day);

            SqlParameter job_id = new SqlParameter();
            job_id.ParameterName = "@job_id";
            job_id.SqlDbType = System.Data.SqlDbType.Int;
            job_id.Direction = System.Data.ParameterDirection.Input;
            job_id.Value = record.Job_id;
            command.Parameters.Add(job_id);

            SqlParameter salary = new SqlParameter();
            salary.ParameterName = "@salary";
            salary.SqlDbType = System.Data.SqlDbType.Int;
            salary.Direction = System.Data.ParameterDirection.Input;
            if (record.Salary == null) record.Salary = 0;
            salary.Value = record.Salary;
            command.Parameters.Add(salary);

            command.ExecuteNonQuery();
        }

        public void Update(PersonRecord record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"UPDATE Persons 
                                    SET name = @name,
                                        birth_day = @birth_day,
                                        job_id = @job_id
                                    WHERE id = @id";

            SqlParameter id = new SqlParameter();
            id.ParameterName = "@id";
            id.SqlDbType = System.Data.SqlDbType.Int;
            id.Direction = System.Data.ParameterDirection.Input;
            id.Value = record.Id;
            command.Parameters.Add(id);

            SqlParameter name = new SqlParameter();
            name.ParameterName = "@name";
            name.SqlDbType = System.Data.SqlDbType.VarChar;
            name.Direction = System.Data.ParameterDirection.Input;
            name.Value = record.Name;
            command.Parameters.Add(name);

            SqlParameter birth_day = new SqlParameter();
            birth_day.ParameterName = "@birth_day";
            birth_day.SqlDbType = System.Data.SqlDbType.DateTime;
            birth_day.Direction = System.Data.ParameterDirection.Input;
            birth_day.Value = record.Birt_day;
            command.Parameters.Add(birth_day);

            SqlParameter job_id = new SqlParameter();
            job_id.ParameterName = "@job_id";
            job_id.SqlDbType = System.Data.SqlDbType.Int;
            job_id.Direction = System.Data.ParameterDirection.Input;
            job_id.Value = record.Job_id;
            command.Parameters.Add(job_id);

            command.Connection = getConnection();

            command.ExecuteNonQuery();
            command.Connection.Close();
        }

        public void Delete(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"DELETE FROM Persons 
                                    WHERE id = @id";

            SqlParameter pId = new SqlParameter();
            pId.ParameterName = "@id";
            pId.SqlDbType = System.Data.SqlDbType.BigInt;
            pId.Direction = System.Data.ParameterDirection.Input;
            pId.Value = id;
            command.Parameters.Add(pId);

            command.Connection = getConnection();
            command.ExecuteNonQuery();

            command.Connection.Close();
        }
    }
}