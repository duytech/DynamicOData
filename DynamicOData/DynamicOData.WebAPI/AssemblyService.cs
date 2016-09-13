using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicOData.WebAPI
{
    public class AssemblyService : IAssemblyService
    {
        public Type[] AssemblyTypes { get; set; }

        public Type GetType(string assemblyName, string name) =>
            AssemblyTypes.FirstOrDefault(t => t.FullName.Equals($"{assemblyName}.{name}", System.StringComparison.OrdinalIgnoreCase));

        public Type GetType(string name) =>
            AssemblyTypes.FirstOrDefault(t => t.Name.Equals($"{name}", System.StringComparison.OrdinalIgnoreCase));
    }
}