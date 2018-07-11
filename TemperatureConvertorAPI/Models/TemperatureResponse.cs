using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemperatureConvertorAPI.Controllers;

namespace TemperatureConvertorAPI.Models
{
    public class TemperatureResponse
    {
        public double Temperature { get; set; }
        public TemperatureType Type { get; set; }
    }
}