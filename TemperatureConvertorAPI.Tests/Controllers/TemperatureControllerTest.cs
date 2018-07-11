using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureConvertorAPI;
using TemperatureConvertorAPI.Controllers;

namespace TemperatureConvertorAPI.Tests.Controllers
{
    public enum TemperatureType
    {
        Fahrenheit, DegreeCelcius
    }

    [TestClass]
    public class TemperatureControllerTest
    {
        [TestMethod]
        public void Post()
        {
            // Arrange
            TemperatureController controller = new TemperatureController();

            // Act
            var results = controller.GetTemperature(10 , (int)TemperatureType.DegreeCelcius);

            // Assert
            Assert.AreEqual(-12.2232, results.Temperature);

        }

    }
}
