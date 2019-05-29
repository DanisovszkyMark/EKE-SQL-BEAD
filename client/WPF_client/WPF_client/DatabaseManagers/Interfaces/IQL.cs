using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_client.DatabaseManagers.Records;

namespace WPF_client.DatabaseManagers.Interfaces
{
    /// <summary>
    /// Biztosítja az adatlekérdezés funkcióit
    /// </summary>
    interface IQL
    {
        List<Record> Select();
        Record Select(Record record);
    }
}
