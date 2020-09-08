using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    [AttributeUsage(System.AttributeTargets.Class, AllowMultiple = false)]
    public class SampleAttribute : Attribute
    {
        public SampleAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}
