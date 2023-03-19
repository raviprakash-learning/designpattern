using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7AdaptorDesignPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
       

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IWeatherForecastProviderAdaptor _weatherForecastProviderAdaptor;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,IWeatherForecastProviderAdaptor weatherForecastProviderAdaptor)
        {
            _logger = logger;
            this._weatherForecastProviderAdaptor = weatherForecastProviderAdaptor;
        }

        [HttpGet]
        public string Get()
        {
           return this._weatherForecastProviderAdaptor.Get();   
        }
    }
}
