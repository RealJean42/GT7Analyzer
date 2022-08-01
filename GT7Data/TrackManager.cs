using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GT7Data
{
    public class TrackManager
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="track"></param>
        /// <param name="path"></param>
        /// <param name="samplingRate">1: use all samples, 4=use every 4th sample for track border</param>
        public string SaveTrack(Track track, string path, int samplingRate=1)
        {
            if(samplingRate>1)
            {
                track.TrackLeft = CreateTrackPositions(track.TrackLeft, samplingRate);
                track.TrackRight = CreateTrackPositions(track.TrackRight, samplingRate);
            }
            // create filename
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            path = Path.Combine(path,track.Name + ".json");
            var options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(track, options);
            File.WriteAllText(path, jsonString);
            return path;
        }

        /// <summary>
        /// Reduce the number of samples for the track borders.
        /// Racing line will not be reduced
        /// </summary>
        /// <param name="data"></param>
        /// <param name="samplingRate"></param>
        /// <returns></returns>
        private static IList<TrackPosition> CreateTrackPositions(IList<TrackPosition> data, int samplingRate)
        {
            IList<TrackPosition> track = new List<TrackPosition>();
            for (int i = 0; i < data.Count(); i = i + samplingRate)
            {
                track.Add((TrackPosition)data[i]);
            }
            return track;
        }

        public Track LoadTrack(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonSerializer.Deserialize<Track>(jsonString)!;
        }
    }
}
