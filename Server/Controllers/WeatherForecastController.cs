using BlazorNet5Samples.Client.Data;
using BlazorNet5Samples.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BlazorNet5Samples.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastsController : Controller
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public WeatherForecastsController(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet]
        public async Task<ActionResult<WeatherForecast[]>> Get(int daysFromNow, int count)
        {
            if (daysFromNow + count > 10000)
            {
                return BadRequest("The weather can only be predicted 10,000 days in the future!");
            }
            return await _weatherForecastService.GetForecastAsync(daysFromNow, count);
        }
    }
}