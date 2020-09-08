using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public interface IBrowserStorage
    {
        ValueTask DeleteAsync(string key);
        ValueTask<(bool success, TValue value)> GetAsync<TValue>(string key);
        ValueTask SetAsync(string key, object value);
    }
}
