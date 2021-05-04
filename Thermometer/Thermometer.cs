using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thermometer.Enum;
using Thermometer.Model;

namespace Thermometer
{
    class Thermometer : ThermometerModel
    {

        /// <summary>
        /// Thermometer constructor
        /// </summary>
        /// <param name="freezingPoint"></param>
        /// <param name="boilingPoint"></param>
        public Thermometer(double freezingPoint, double boilingPoint)
        {
            InitThermometerModelProperties(freezingPoint, boilingPoint);
        }

        /// <summary>
        /// Thermometer constructor
        /// </summary>
        /// <param name="freezingPoint"></param>
        /// <param name="boilingPoint"></param>
        /// <param name="customThresholdPoint"></param>
        public Thermometer(double freezingPoint, double boilingPoint, double customThresholdPoint)
        {
            CustomThresholdPoint = customThresholdPoint;
            InitThermometerModelProperties(freezingPoint, boilingPoint);
        }

        /// <summary>
        /// initialize Thermometer model
        /// </summary>
        public Thermometer()
        {
            Temperature = new TemperatureModel();
        }

        /// <summary>
        /// initialize Thermometer property/ies
        /// </summary>
        private void InitThermometerModelProperties(double freezingPoint, double boilingPoint)
        {
            Temperature = new TemperatureModel();

            if (freezingPoint != boilingPoint)
            {
                FreezingPoint = freezingPoint;
                BoilingPoint = boilingPoint;
            }
            else
            {
                throw new ArgumentException("You cannot set freezing point and boiling point with the same value.");
            }
        }

        /// <summary>
        /// Reads the given temperature and validates what threshold point it belongs.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public TemperatureModel ReadTemperature(double value)
        {
            Temperature.Value = value;

            if (FreezingPoint != null || BoilingPoint != null)
            {
                if (value <= FreezingPoint)
                {
                    GetFreezingPoint();
                }
                else if (value >= BoilingPoint)
                {
                    GetBoilingPoint();
                }
                else if (CustomThresholdPoint != null && CustomThresholdPoint == value)
                {
                    GetCustomPoint();
                }
                else
                {
                    Temperature.Status = null;
                    Temperature.Message = "";
                }
            }
            else
            {
                throw new NullReferenceException("The FreezingPoint / BoilingPoint is null.");
            }

            return Temperature;
        }

        /// <summary>
        /// Read temperature and displays a Threshold point warning depending on the selected ThresholdPoint enum
        /// </summary>
        /// <param name="value"></param>
        /// <param name="thresholdPoint"></param>
        /// <returns></returns>
        public TemperatureModel ReadTemperature(double value, ThresholdPoint thresholdPoint)
        {
            Temperature.Value = value;

            if (thresholdPoint == ThresholdPoint.FreezingPoint && value <= FreezingPoint)
            {
                GetFreezingPoint();
                //Temperature.Message = "Freezing point reached";
            }
            else if (thresholdPoint == ThresholdPoint.BoilingPoint && value >= BoilingPoint)
            {
                GetBoilingPoint();
                //Temperature.Message = "Boiling point reached";
            }
            else if (thresholdPoint == ThresholdPoint.CustomPoint && value == CustomThresholdPoint)
            {
                GetCustomPoint();
                //Temperature.Message = "Freezing point reached";
            }
            else
            {
                Temperature.Status = null;
                Temperature.Message = "";
            }

            return Temperature;
        }

        /// <summary>
        /// set temperature model properties into freezing point result
        /// </summary>
        private void GetFreezingPoint()
        {
            if (ShowTriggeredPointOnce) //if the users want to dislay the threshold point at the message once
            {
                if (Temperature.Status != ThresholdPoint.FreezingPoint)
                {
                    Temperature.Message = "Freezing point reached";
                }
                else
                {
                    Temperature.Message = "";
                }
            }
            else
            {
                Temperature.Message = "Freezing point reached";
            }

            Temperature.Status = ThresholdPoint.FreezingPoint;
        }

        /// <summary>
        /// set temperature model properties into boiling point result
        /// </summary>
        private void GetBoilingPoint()
        {
            if (ShowTriggeredPointOnce) //if the users want to dislay the threshold point at the message once
            {
                if (Temperature.Status != ThresholdPoint.BoilingPoint)
                {
                    Temperature.Message = "Boiling point reached";
                }
                else
                {
                    Temperature.Message = "";
                }
            }
            else
            {
                Temperature.Message = "Boiling point reached";
            }

            Temperature.Status = ThresholdPoint.BoilingPoint;
        }

        /// <summary>
        /// set temperature model properties into Custom threshold point result
        /// </summary>
        private void GetCustomPoint()
        {
            if (ShowTriggeredPointOnce) //if the users want to dislay the threshold point at the message once
            {
                if (Temperature.Status != ThresholdPoint.CustomPoint)
                {
                    Temperature.Message = "Custom threshold point reached";
                }
                else
                {
                    Temperature.Message = "";
                }
            }
            else
            {
                Temperature.Message = "Custom threshold reached";
            }

            Temperature.Status = ThresholdPoint.CustomPoint;
        }


        
    }
}