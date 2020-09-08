using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public class SampleProvider : ISampleProvider
    {
        protected List<(string Name, string Route)> samples;

        public SampleProvider()
        {
            samples = GetSamples(typeof(SampleProvider).Assembly).ToList();
        }

        public SampleProvider(IOptions<SampleProviderOptions> sampleOptions) : this()
        { 
            foreach (var assembly in sampleOptions.Value.Assemblies.Distinct())
            {
                samples.AddRange(GetSamples(assembly));
            }
        }

        public virtual IEnumerable<(string Name, string Route)> GetSamples()
        {
            return samples;
        }

        static IEnumerable<(string Name, string Route)> GetSamples(Assembly assembly)
        {
            return assembly.ExportedTypes
                .Where(type => type.IsSubclassOf(typeof(ComponentBase)))
                .Where(component => component.GetCustomAttributes(inherit: true).OfType<SampleAttribute>().Count() > 0)
                .Select(sample =>
                {
                    var attributes = sample.GetCustomAttributes(inherit: true);
                    var sampleName = attributes.OfType<SampleAttribute>().First().Name;
                    var route = attributes.OfType<RouteAttribute>().First().Template;
                    return (sampleName, route);
                });
        }
    }
}
