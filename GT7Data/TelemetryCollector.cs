using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GT7Data
{
    public class TelemetryCollector<T> where T : Telemetry
    {
        private ConcurrentDictionary<TimeSpan, T> Telemetry { get; set; }

        public TelemetryCollector()
        {
            Telemetry=new ConcurrentDictionary<TimeSpan, T>();
        }

        public TelemetryCollector(IList<T> list)
        {
            Telemetry = new ConcurrentDictionary<TimeSpan, T>(list.ToDictionary(e=>e.Timestamp,e=>e));
        }

        public void Reset()
        {
            Telemetry.Clear();
        }

        public void AddData(T record)
        {
            Telemetry.TryAdd(record.Timestamp,record);
        }

        public int NumberOfRecords()
        {
            return Telemetry.Count();
        }
        public int NumberOfLaps()
        {
            return Telemetry.Values.Select(t => t.Lap).Where(t=>t>0).Distinct().Count();
        }

        public IList<T> GetLap(short lap)
        {
            return Telemetry.Values.Where(t => t.Lap == lap).OrderBy(t => t.Timestamp).ToList();
        }
        public IList<T> GetAll()
        {
            return Telemetry.Values.OrderBy(t => t.Timestamp).ToList();
        }
    }
}
