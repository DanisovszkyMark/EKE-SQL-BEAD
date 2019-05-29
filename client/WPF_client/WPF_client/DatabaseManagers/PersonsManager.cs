using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
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
