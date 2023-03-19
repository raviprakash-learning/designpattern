using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7AdaptorDesignPattern
{
    public class WeatherForecastProviderAdaptor : IWeatherForecastProviderAdaptor
    {
        private readonly IWeatherForecastProvider _weatherForecastProvider;

        public WeatherForecastProviderAdaptor(IWeatherForecastProvider weatherForecastProvider)
        {
            this._weatherForecastProvider = weatherForecastProvider;
        }

        public string Get()
        {
           IEnumerable<string> weatherdatas=  _weatherForecastProvider.Get().Select(x=>$"Date: {x.Date}|| TemperatureC: {x.TemperatureC}|| TemperatureF: {x.TemperatureF}");
           return string.Join(Environment.NewLine, weatherdatas);
        }
    }
}
