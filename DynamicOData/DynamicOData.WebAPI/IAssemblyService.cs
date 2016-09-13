using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicOData.WebAPI
{
    public interface IAssemblyService
    {
        Type[] AssemblyTypes { get; set; }
        Type GetType(string name);
        Type GetType(string assemblyName, string name);
    }
}
