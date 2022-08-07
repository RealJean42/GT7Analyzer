using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GT7Data
{
    public class TelemetryManager
    {
        private List<Color> LapColors = new List<Color>() { 
            Color.White, 
            Color.Beige, 
            Color.LightCoral, 
            Color.LightGreen, 
            Color.LightSalmon, 
            Color.LightYellow 
        };
        public Track Track { get; set; }

        public Vector3Ser CurrentPosition { get; set; } = new Vector3Ser();

        public int CurrentPositionIndex { get; set; }
    
        public LapData ReferenceLap { get; set; }

        public List<LapData> Laps { get; set; } =new List<LapData>();
        /// <summary>
        /// Distance between samples used for normalized data
        /// Default: 5 meters
        /// </summary>
        public float SampleStep { get; set; } = 5.0f;

        public Chartline ConvertToChartline(LapData lap, DataType dataType)
        {
            Chartline line = new Chartline();
            line.Type = dataType;
            line.LapId = (int)dataType + "_" + lap.Lap;
            if(lap !=null)
            {
                foreach(var entry in lap.TelemetryList)
                {
                    switch(dataType)
                    {
                        case DataType.Speed:
                            line.Samples.Add(entry.SpeedMS * 3.6f);
                            break;
                        case DataType.Throttle:
                            line.Samples.Add(entry.Throttle);
                            break;
                        case DataType.Brake:
                            line.Samples.Add(entry.Brake);
                            break;
                        default:
                            break;
                    }
                }
            }
            return line;
        }

        public List<LapData> ConvertToLapList(IList<Telemetry> telemetry)
        {
            List<LapData> list = new List<LapData>();

            Vector3Ser start = null;
            int lastLap = 0;
            TimeSpan startTime=TimeSpan.Zero;
            Telemetry lastData = null;
            LapData currentLap = null;
            // don't know the position of the startline. Take first data from first lap as reference
            foreach(var data in telemetry)
            {
                if(data.Lap>0)
                {
                    // check for first entry in lap
                    if(lastLap<data.Lap)
                    {
                        if(lastLap==0)
                        {
                            start = data.Position;
                        }
                        if(currentLap!=null)
                        {
                            // todo. Calculate exact time
                            currentLap.Laptime = data.Timestamp - startTime;
                            list.Add(currentLap);
                        }
                        startTime = data.Timestamp;
                        currentLap = new LapData { Lap = data.Lap, LapId="Lap1", LineColor= LapColors[data.Lap%LapColors.Count] };
                    }
                    currentLap.TelemetryList.Add(data);
                    lastData = data;
                    lastLap = data.Lap;
                }
            }
            return list;
        }
    }
}
