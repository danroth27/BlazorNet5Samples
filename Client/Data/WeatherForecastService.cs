using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading;
using System.Threading.Tasks;
using BlazorNet5Samples.Shared;

namespace BlazorNet5Samples.Client.Data
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherForecast[]> GetForecastAsync(int daysFromNow = 1, int count = 5)
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>($"api/WeatherForecasts?daysFromNow={daysFromNow}&count={count}");
        }
    }
}