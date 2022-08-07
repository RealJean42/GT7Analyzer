using System;
using System.Collections.Generic;
using System.Text;

namespace GT7Data
{
    public class TelemetryManager
    {
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
                            line.Samples.Add(entry.SpeedMS);
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
    }
}
