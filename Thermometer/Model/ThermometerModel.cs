namespace Thermometer.Model
{
    public class ThermometerModel
    {
        /// <summary>
        /// gets or sets Thermometer Temperature model
        /// </summary>
        protected TemperatureModel Temperature { get; set; }

        /// <summary>
        /// gets or sets thermometer Freezing Point
        /// </summary>
        public double? FreezingPoint { get; set; } = null;

        /// <summary>
        /// gets or sets thermometer boiling point 
        /// </summary>
        public double? BoilingPoint { get; set; } = null;

        /// <summary>
        /// gets or sets thermometer custom threshold point with a default value of null
        /// </summary>
        public double? CustomThresholdPoint { get; set; } = null;

        /// <summary>
        /// gets or sets ShowTriggeredPointOnce
        /// </summary>
        public bool ShowTriggeredPointOnce { get; set; } 

    }
}
