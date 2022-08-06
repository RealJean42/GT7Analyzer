using System;
using System.Collections.Generic;
using System.Text;

namespace GT7Data
{
    public class LapData
    {
        public int Lap { get; set; }

        public TimeSpan Laptime { get; set; }

        public List<Telemetry> TelemetryList { get; set; }

        public List<Telemetry> TelemetryListNormalized { get; set; }

    }
}
