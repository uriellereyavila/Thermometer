using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thermometer.Enum;

namespace Thermometer.Model
{
    public class TemperatureModel
    {
        /// <summary>
        /// gets or sets temperature status
        /// </summary>
        public ThresholdPoint? Status { get; set; }
        /// <summary>
        /// gets or sets temperature value
        /// </summary>
        public double Value { get; set; }

        /// <summary>
        /// gets unit of measurement
        /// </summary>
        public readonly string UnitOfMeasurement = "Celsius";

        /// <summary>
        /// gets unit of measurement prefix
        /// </summary>
        public readonly char prefix = 'C';

        /// <summary>
        /// gets or sets temperature message
        /// </summary>
        public string Message { get; set; }
    }
}
