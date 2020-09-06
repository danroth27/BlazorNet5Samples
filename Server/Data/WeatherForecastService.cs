using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorNet5Samples.Shared;

namespace BlazorNet5Samples.Server.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly List<WeatherForecast> forecasts = new List<WeatherForecast>();

        public async Task<WeatherForecast[]> GetForecastAsync(int daysFromNow, int count)
        {
            await Task.Delay(Math.Min(count * 20, 2000));

            var rng = new Random();

            while (forecasts.Count < daysFromNow + count)
            {
                forecasts.Add(new WeatherForecast
                {
                    Date = DateTime.Today.AddDays(forecasts.Count),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                });
            }

            return forecasts.Skip(daysFromNow).Take(count).ToArray();
        }
    }
}