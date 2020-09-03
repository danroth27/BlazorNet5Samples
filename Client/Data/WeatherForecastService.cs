using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
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

        public async Task<IEnumerable<WeatherForecast>> GetForecastAsync()
        {
            return await _httpClient.GetFromJsonAsync<WeatherForecast[]>("api/WeatherForecasts");
        }
    }
}