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

        public Record Select(Record record)
        {
            throw new NotImplementedException();
        }

        public void Insert(PersonRecord record)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"INSERT INTO Persons(name, birth_day, job_id, salary)
                                    VALUES (@name, @birth_day, @job_id, @salary)";

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
            salary.Value = record.Salary;
            command.Parameters.Add(salary);

            command.ExecuteNonQuery();
        }

        public int Update(Record record)
        {
            throw new NotImplementedException();
        }

        public int Delete(Record record)
        {
            throw new NotImplementedException();
        }
    }
}