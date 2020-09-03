using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetForecastAsync();
    }
}