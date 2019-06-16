using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class ParentRecord
    {
        private int id;
        public int Id
        {
            get { return id; }
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
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
        public DateTime Birth_day
        {
            get { return birth_day; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                birth_day = value;
            }
        }

        public ParentRecord(string Name, DateTime Birth_day)
        {
            this.Name = Name;
            this.Birth_day = Birth_day;
        }

        public ParentRecord(int Id, string Name, DateTime Birth_day) : this(Name, Birth_day)
        {
            this.Id = Id;
        }

        public ParentRecord()
        {

        }
    }
}