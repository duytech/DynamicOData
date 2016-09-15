using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicOData.Dynamic.Models
{
    public class ForeignKey
    {
        public string RelatedTable { get; set; }
        public string RelatedColumn { get; set; }
    }
}
