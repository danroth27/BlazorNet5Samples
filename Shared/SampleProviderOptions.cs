using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public class SampleProviderOptions
    {
        public IList<Assembly> Assemblies { get; } = new List<Assembly>();
    }
}
