using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicOData.Dynamic.Models
{
    public class DatabaseTable
    {
        public string Name { get; set; }
        public string Schema { get; set; }
        public IEnumerable<DatabaseColumn> Columns { get; set; }
        public List<string> AggregateFunctions { get; set; }
    }
}
