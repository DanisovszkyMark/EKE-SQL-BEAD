using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService.DatabaseManagers.Records;

namespace WCFService.DatabaseManagers.Interfaces
{
    interface IQL
    {
        List<Record> Select();

        Record Select(Record record);
    }
}
