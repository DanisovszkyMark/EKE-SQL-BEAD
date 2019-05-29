using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_client.DatabaseManagers.Records;

namespace WPF_client.DatabaseManagers.Interfaces
{
    /// <summary>
    /// Biztosítja az adatmenedzsment támogatását
    /// </summary>
    interface IDML
    {
        int Insert(Record record);

        int Update(Record record);

        int Delete(Record record);
    }
}
