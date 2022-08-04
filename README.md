# GT7Analyzer
Some experiments collecting, processing and visualizing telemetry data from GT7.
The final goal is to be able to compare laps to each other to improve lap times.

Credits go to Nenkai for figuring out how to decrypt the telemetry packets from the game and providing an interface with his PDTools https://github.com/Nenkai/PDTools/tree/master/PDTools.SimulatorInterface
 
## Tools included
* `GT7Logger` - Collecting data with some realtime visualization, saving data and extracting track data
* `GT7Visualizer` - Simple displaying of extracted track data
* Binaries can be found here <a href="https://github.com/RealJean42/GT7Analyzer/releases/tag/v0.1.0">Binary download</a>. .NET6 runtimes must be installed

# GT7Logger
### Configuration
The application contains a config file where you can set your PS7 IP and the directory for your collected data.
### Collecting and visualizing data
By starting the recording all data from the PS7 will be captured and stored in memory (small amount of data, don't worry about memory limits). Some of the captured data is shown in the interface.
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/Collecting.PNG"></img>
### Saving collected data
You can save your collected data completely or by lap. You may chose between CSV and JSON format. 3D vectors are tricky to save in the csv. Order in the csv: Position, Velocity and AngularVelocity.
<br/>
<strong>`Save as JSON to extract track data`</strong>
<br/>
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/Extracting.PNG"></img>
### Collect and save track data
There is a simplistic way to gather track data. In one sentence: Ride the lines!
Select the track you want to create and use a time trial with racing line enabled.
I suggest to make 5 laps:
* 1 Lap: Ride the racing line as close as possible. Speed doesn't matter. I suggest half the speed you usually would
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/Raceline.jpg"></img>
* 2 Lap: Have some fun and prepare to do the left border of the track
* 3 Lap: Ride left track border line as close as possible. I suggest driving slow in corners and not more tha 160 km/h on straights.
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/TrackLeft.jpg"></img>
* 4 Lap: Free lap, prepare for right border of the track
* 5 Lap:Ride right track border as close as possible
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/TrackRight.jpg"></img>

The data for the left and right track boarder will be reduced when saving. Before saving the track you can chose which lap is for which line. If you mess up lap 5 you may add a 6th lap and chose that as the right border.

# GT7Visualizer
Start GT7Visualizer and select a track to visualize
<img src="https://github.com/RealJean42/GT7Analyzer/blob/master/Docs/Images/visualize.PNG"></img>
# Next steps
Adding lap selector to visualization and compare laps (line, speed, throttle, brake, time delta,etc)
I'm planning to use the racing line from the track data as positional reference for delta time evaluations.

# Example data
Some telemetry and track data examples in JSON and CSV can be found in the folder "exampleData".
The data is currently a subset of the complete data but can be extended easly if needed.

Current JSON example data record:
```json
[
  {
    "Timestamp": "08:09:26.0460000",
    "CarCode": 1973,
    "Lap": 1,
    "Throttle": 255,
    "Brake": 0,
    "Gear": 4,
    "SpeedMS": 40.42767,
    "Steering": 0,
    "EngineRPM": 5296.4834,
    "Position": {
      "X": 100.589,
      "Y": 1.913549,
      "Z": 127.85916
    },
    "Velocity": {
      "X": -16.723803,
      "Y": 1.4781482,
      "Z": 36.776703
    }
]
```
