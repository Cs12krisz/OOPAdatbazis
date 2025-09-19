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
    }
}
