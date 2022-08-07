using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GT7Data
{

    public class LapData
    {
        public bool Show { get; set; }
        public string LapId { get; set; }
        public Color LineColor { get; set; } = Color.White;
        public int Lap { get; set; }
        public TimeSpan Laptime { get; set; }
        public List<Telemetry> TelemetryList { get; set; } = new List<Telemetry>();
        public List<Telemetry> TelemetryListNormalized { get; set; }= new List<Telemetry>();

    }
}
