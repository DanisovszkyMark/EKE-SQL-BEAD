using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class Record
    {
        private readonly int? id;
        public int? Id
        {
            get { return id; }
        }

        protected bool deleted;
        public bool Deleted
        {
            get { return deleted; }
            set
            {
                if (value == true && deleted) throw new Exception("Already deleted record!");
                deleted = value;
            }
        }

        public Record(int? id)
        {
            if (id == null) throw new ArgumentNullException();

            this.id = id;
        }

        protected Record()
        {
            deleted = false;
        }
    }
}