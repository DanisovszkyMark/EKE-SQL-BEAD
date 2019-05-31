using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class RefreshRecord
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

        private DateTime time;
        public DateTime Time
        {
            get { return time; }
            set { time = value; }
        }

        public RefreshRecord()
        {

        }
    }
}