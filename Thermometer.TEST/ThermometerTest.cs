using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Thermometer.Enum;

namespace Thermometer.TEST
{
    [TestClass]
    public class ThermometerTest
    {
        private Random random = new Random(); //sample data using Random Class

        /// <summary>
        /// Reads a valid temperature
        /// </summary>
        [TestMethod]
        public void Read_Valid_Temperature()
        {
            Thermometer thermometer = new Thermometer();
            thermometer.FreezingPoint = -20;
            thermometer.BoilingPoint = 20;

            Assert.IsNotNull(thermometer.ReadTemperature(random.Next(-10, 10)));
        }

        /// <summary>
        /// set a null value for freezing or boiling point
        /// </summary>
        [TestMethod]
        public void Set_Null_Boiling_FreezingPoint()
        {
            Thermometer thermometer = new Thermometer();

            Assert.ThrowsException<NullReferenceException>(() => thermometer.ReadTemperature(random.Next(-10, 10)));
        }

        /// <summary>
        /// set equal boiling and freezing poin
        /// </summary>
        [TestMethod]
        public void Set_equal_boiling_freezing_point()
        {
            Assert.ThrowsException<ArgumentException>(() => new Thermometer(10, 10));
        }

        /// <summary>
        /// read a temperature that reached in custom threshold point
        /// </summary>
        [TestMethod]
        public void Read_valid_Custom_ThresPoint()
        {
            Thermometer thermometer = new Thermometer();
            thermometer.FreezingPoint = 20;
            thermometer.BoilingPoint = -20;
            thermometer.CustomThresholdPoint = 12;

            var temperature = thermometer.ReadTemperature(12, ThresholdPoint.CustomPoint);

            Assert.AreEqual(temperature.Status, ThresholdPoint.CustomPoint);
        }
    }
}
