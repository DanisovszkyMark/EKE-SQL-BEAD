using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.DatabaseManagers.Records;

namespace WCFService.DatabaseManagers.Interfaces
{
    interface IDML
    {
        int Insert(Record record);

        int Update(Record record);

        int Delete(Record record);
    }
}
