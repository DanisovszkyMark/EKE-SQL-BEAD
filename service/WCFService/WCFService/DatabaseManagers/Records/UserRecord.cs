using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.DatabaseManagers.Records
{
    public class UserRecord
    {
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length < 0 || value.Length > 50) throw new ArgumentOutOfRangeException();
                username = value;
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                else if (value.Length != 16) throw new ArgumentOutOfRangeException();
                password = value;
            }
        }

        private bool logged;
        public bool Logged
        {
            get { return logged; }
            set { logged = value; }
        }

        public UserRecord(string Username)
        {
            this.Username = Username;
        }

        public UserRecord()
        {
        }
    }
}