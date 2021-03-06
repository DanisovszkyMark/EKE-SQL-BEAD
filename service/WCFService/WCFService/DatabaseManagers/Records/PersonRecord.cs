﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class PersonRecord
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0) throw new Exception();
                id = value;
            }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length > 250) throw new ArgumentOutOfRangeException();

                name = value;
            }
        }

        private DateTime birth_day;
        public DateTime Birt_day
        {
            get { return birth_day; }
            set
            {
                if (value == null) throw new ArgumentNullException();

                birth_day = value;
            }
        }

        private int job_id;
        public int Job_id
        {
            get { return job_id; }
            set
            {
                job_id = value;
            }
        }

        private int? salary;
        public int? Salary
        {
            get { return salary; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                salary = value;
            }
        }

        public PersonRecord(int id)
        {
            this.Id = id;
        }

        public PersonRecord()
        {
        }
    }
}