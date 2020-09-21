using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RefitConsole.cs
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var weatherAPI = RestService.For<IWeatherAPI>("http://localhost:5001");
            var forecasts = await weatherAPI.Get();
            forecasts.ToList().ForEach(f => Console.WriteLine($"Date: {f.Date}, Celsius: {f.TemperatureC}, Fahrenheit: {f.TemperatureF}, Summary: {f.Summary} \n"));
        }
    }

    public interface IWeatherAPI
    {
        [Get("/weatherforecast")]
        Task<IEnumerable<WeatherForecast>> Get();
    }

    public class WeatherForecast
    {
        public DateTime Date { get; set; }
        public int TemperatureC { get; set; }
        public string Summary { get; set; }
        public int TemperatureF { get; set; }
    }
}
