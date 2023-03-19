using System.Collections.Generic;

namespace _7AdaptorDesignPattern
{
    public interface IWeatherForecastProvider
    {
        IEnumerable<WeatherForecast> Get();
    }
}