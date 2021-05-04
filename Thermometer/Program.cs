using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thermometer.Enum;
using Thermometer.Model;

namespace Thermometer
{
    class Program
    {
        static void Main(string[] args)
        {
            /**********************************************************************************************
             * 
             *  Assumed that the data is on streaming 
             *  NOTE: you must initialize the Thermometer class and set its property first before you start 
             *  read the temperature
             *  
             * ************************************************************************************************/

            Thermometer thermometer = new Thermometer(-20, 30, 8); // initialize Thermometer class
            Random rand = new Random(); //use Random class for generate sample data

            //thermometer.FreezingPoint = -20;          // other way of setting freezing point
            //thermometer.BoilingPoint = 20;            // other way of setting boiling point 
            //thermometer.CustomThresholdPoint = 8;     // other way of setting custom threshold point
            //thermometer.ShowTriggeredPointOnce = true;  // show a freezing, boiling & custom threshold point once

            while (true) // use while loop to make it like a streaming
            {
                var temperatureObj = thermometer.ReadTemperature(0, ThresholdPoint.FreezingPoint);

                Console.WriteLine($"{temperatureObj.Value} {temperatureObj.prefix} {temperatureObj.Message}");
                Thread.Sleep(1500);
            }
        }
    }
}
