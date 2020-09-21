using BlazorAppDemo.ViewModels;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorAppDemo.Services
{
    public interface IWeatherAPI
    {
        [Get("/weatherforecast")]
        Task<IEnumerable<WeatherForecast>> Get();
    }
}
