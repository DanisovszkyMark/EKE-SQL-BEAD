using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_client.DatabaseManagers.Interfaces;
using WPF_client.DatabaseManagers.Records;

namespace WPF_client.DatabaseManagers
{
    class PersonsManager : BaseDatabaseManager, IDML, IQL
    {
        public List<Record> Select()
        {
            List<Record> records = new List<Record>();

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

        public int Insert(Record record)
        {
            throw new NotImplementedException();
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
