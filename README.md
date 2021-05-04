<h2>Thermometer Class</h2>

<p><b>Thermometer</b> is an instrument for measuring and indicating temperature, typically one consisting of a narrow, hermetically sealed glass tube marked 
  with graduations and having at one end a bulb containing mercury or alcohol that expands and contracts in the tube with heating and cooling.</p>

<p>The <b>Thermometer Class</b> can read the temperature of some external source in Celsius. The user can also set the boiling point, freezing point, and 
custom point threshold. These thresholds will inform the users that the given temperature reached on that specific point. The user can</p>

<h4>Limitations:</h4>

- Thermometer Class cannot set Freezing, Boiling and Custom point with the same value.
- The user can only set 1 custom threshold.


<h4>Initializing Thermometer Class</h4>

  ```
  //Initialize Thermometer class
  
  Thermometer thermometer = new Thermometer(-10, 20, 0); //freezing, boiling, custom threshold point
  ```
or

  ```
  //Initialize Thermometer class
  Thermometer thermometer = new Thermometer();
  
  //setting freezing, boiling, custom threshold point propert/ies
  thermometer.FreezingPoint = -10;
  thermometer.BoilingPoint = 20;
  thermometer.CustomThresholdPoint = 0;
  ```

<h3>NOTE:</h3>

You cannot set the threshold point(s) with the same value


<h3>Functions:</h3>

- ```TemperatureModel ReadTemperature(double value)``` reads a given temperature and validates the temperature if it is reached into a certain threshold point.
- ```TemperatureModel ReadTemperature(double value, ThresholdPoint thresholdPoint)``` reads a given temperature and validates if the temperature reached into a given ThresholdPoint enum


<h3>Properties:</h3>

- ```BoilingPoint ``` gets or sets boiling point of the thermometer
- ```FreezingPoint``` gets or sets Freezing Point of the thermometer
- ```CustomThresholdPoint```  gets or sets custom threshold point of the thermometer
- ```ShowTriggeredPointOnce``` Calls or trigger the certain threshold point once if the temperature is repeatedly on a certain threshold point.
