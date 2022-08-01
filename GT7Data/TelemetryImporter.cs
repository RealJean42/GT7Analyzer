using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace GT7Data
{
    public static class TelemetryImporter
    {
        public static IList<Telemetry> LoadData(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Telemetry>>(jsonString)!;
        }
    }
}
