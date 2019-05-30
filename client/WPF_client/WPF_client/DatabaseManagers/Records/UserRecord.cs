using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_client.DatabaseManagers.Records
{
    class UserRecord : Record
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
                else if (value.Length < 0 || value.Length > 50) throw new ArgumentOutOfRangeException();
                password = value;
            }
        }

        public UserRecord(string Username)
        {
            if (Username == null) throw new ArgumentNullException();

            this.Username = Username;
        }

        public UserRecord()
        {
        }
    }
}
