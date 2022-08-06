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
    }
}
