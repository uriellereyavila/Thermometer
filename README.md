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
