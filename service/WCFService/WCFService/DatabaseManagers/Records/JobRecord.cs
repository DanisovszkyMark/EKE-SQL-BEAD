using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class JobRecord
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        private string workplaceName;
        public string WorkplaceName
        {
            get { return workplaceName; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length > 250) throw new ArgumentOutOfRangeException();
                workplaceName = value;
            }
        }

        private string job;
        public string Job
        {
            get { return job; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length > 120) throw new ArgumentOutOfRangeException();
                job = value;
            }
        }

        private string description;
        public string Description
        {
            get { return description; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length > 250) throw new ArgumentOutOfRangeException();
                description = value;
            }
        }

        public JobRecord(string WorkplaceName, string Job, string Description)
        {
            this.WorkplaceName = WorkplaceName;
            this.Job = Job;
            this.Description = Description;
        }

        public JobRecord(int Id, string WorkplaceName, string Job, string Description) : this(WorkplaceName, Job, Description)
        {
            this.Id = Id;
        }

        public JobRecord()
        {

        }
    }
}