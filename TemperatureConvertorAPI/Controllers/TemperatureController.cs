using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using TemperatureConvertorAPI.Models;

namespace TemperatureConvertorAPI.Controllers
{
    public enum TemperatureType
    {
        Fahrenheit, DegreeCelcius
    }
    public class TemperatureController : ApiController
    {
        // POST: api/Temperature
        [ResponseType(typeof(double))]
        public TemperatureResponse GetTemperature(double temperature, int temperatureType)
        {
            double convertedTemperature = 0;
            switch ((TemperatureType)temperatureType)
            {
                case TemperatureType.Fahrenheit:
                    convertedTemperature = ConvertToFahrenheit(temperature);
                    break;
                case TemperatureType.DegreeCelcius:
                    convertedTemperature = ConvertToCelcius(temperature);
                    break;
                default:
                    break;
            }

            return new TemperatureResponse
            {
                Temperature = convertedTemperature,
                Type = temperatureType == 0 ? TemperatureType.DegreeCelcius : TemperatureType.Fahrenheit
            };
        }

        public double ConvertToCelcius(double temperature)
        {
            return (temperature - 32) * 0.5556;
        }

        public double ConvertToFahrenheit(double temperature)
        {
            return (temperature * 18) + 32;
        }
    }
}
