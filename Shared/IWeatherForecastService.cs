using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Shared
{
    public interface IWeatherForecastService
    {
        Task<WeatherForecast[]> GetForecastAsync(int daysFromNow = 1, int count = 5);
    }
}