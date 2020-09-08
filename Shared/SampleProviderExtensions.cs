using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public static class SampleProviderExtensions
    {
        public static IServiceCollection AddSampleProvider(this IServiceCollection services, Action<SampleProviderOptions> configure = null)
        {
            if (configure != null)
            {
                services.Configure<SampleProviderOptions>(configure);
            }
            services.AddSingleton<ISampleProvider, SampleProvider>();
            return services;
        }
    }
}
