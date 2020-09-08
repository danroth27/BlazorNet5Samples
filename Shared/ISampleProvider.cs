using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public interface ISampleProvider
    {
        IEnumerable<(string Name, string Route)> GetSamples();
    }
}
