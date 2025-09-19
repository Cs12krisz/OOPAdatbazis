using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdatbazis.Services
{
    internal interface ISqlStatements
    {
        List<object> GetAllData(string dbName);

        object GetById(int id);

        object AddNewItem(object newRecord);

        object DeleteItem(int id);

        object UpdateItem(object modifiedItem);
    }
}
