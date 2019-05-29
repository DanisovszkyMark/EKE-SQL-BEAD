using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_client.DatabaseManagers.Records
{
    /// <summary>
    /// A rekordoknak ad egy közös őst.
    /// </summary>
    class Record
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
