using DynamicOData.Dynamic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicOData.Dynamic.Reader
{
    public interface ISchemaReader
    {
        IEnumerable<DatabaseTable> GetTables(IEnumerable<TableInfo> tableInfos);
    }
}
