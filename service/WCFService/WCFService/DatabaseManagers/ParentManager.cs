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
    public class ParentManager : BaseDatabaseManager
    {
        public List<ParentRecord> SelectAll()
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Parents";

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

            List<ParentRecord> records = new List<ParentRecord>();

            try
            {
                while(reader.Read())
                {
                    ParentRecord record = new ParentRecord();
                    record.Id = int.Parse(reader["id"].ToString());
                    record.Name = reader["name"].ToString();
                    record.Birth_day = DateTime.Parse(reader["birth_day"].ToString());
                    records.Add(record);
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return records;
        }

        public ParentRecord SelectParent(int id)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Parents 
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

            ParentRecord loadedRecord = new ParentRecord();

            try
            {
                if (reader.Read())
                {
                    loadedRecord = new ParentRecord();
                    loadedRecord.Id = int.Parse(reader["id"].ToString());
                    loadedRecord.Name = reader["name"].ToString();
                    loadedRecord.Birth_day = DateTime.Parse(reader["birth_day"].ToString());
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return loadedRecord;
        }

        public int SelectParentId(string name)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = @"SELECT * 
                                    FROM Parents 
                                    WHERE name = @name";

            SqlParameter pName = new SqlParameter();
            pName.ParameterName = "@name";
            pName.Value = name;
            pName.Direction = System.Data.ParameterDirection.Input;
            pName.DbType = System.Data.DbType.String;
            command.Parameters.Add(pName);

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

            ParentRecord loadedRecord = new ParentRecord();

            try
            {
                if (reader.Read())
                {
                    return int.Parse(reader["id"].ToString());
                }
            }
            catch (Exception)
            {
                throw new DatabaseParameterException();
            }

            return -1;
        }

        public void InsertParent(ParentRecord record)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertParent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", record.Name);
            cmd.Parameters.AddWithValue("@birth_day", record.Birth_day);

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

        public void InsertPersonParent(int person_id, int parent_id)
        {
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "InsertPersonParent";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@person_id", person_id);
            cmd.Parameters.AddWithValue("@parent_id", parent_id);

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