using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace GT7Data
{
    public static class TelemetryExporter
    {
        public static void SaveCSV(IList<Telemetry> data, string path)
        {
            CleanupData(data);
            var config = new CsvConfiguration(CultureInfo.CurrentCulture)
            {
                Delimiter = ";",
                HasHeaderRecord = true
            };
            using (var writer = new StreamWriter(path))
            using (var csvWriter = new CsvWriter(writer, config))
            {
                var map = new DefaultClassMap<Telemetry>();

                map.AutoMap(CultureInfo.InvariantCulture);

                csvWriter.Context.RegisterClassMap(map);
                csvWriter.WriteHeader<Telemetry>();
                csvWriter.NextRecord();
                csvWriter.WriteRecords(data);
            }
        }

        public static void SaveJSON(IList<Telemetry> data, string path)
        {
            CleanupData(data);
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(path, jsonString);
        }

        private static void CleanupData(IList<Telemetry> data)
        {
            // check for empty first entry
            if (data.Any())
            {
                if (data.First().Timestamp == TimeSpan.MinValue)
                {
                    data.RemoveAt(0);
                }
            }
        }
    }
}
