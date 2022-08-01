using System;
using System.Collections.Generic;
using System.Linq;

namespace GT7Data
{
    public class Track
    {
        public Track()
        { }

        public Track(string trackname)
        {
            Name= trackname;
        }

        public string Name { get; set; }

        public IList<Raceline> Raceline { get; set; }
        public IList<TrackPosition> TrackLeft { get; set; }
        public IList<TrackPosition> TrackRight { get; set; }

        public float MinX  => Raceline.Min(t => t.Position.X);
        public float MaxX => Raceline.Max(t => t.Position.X);
        public float MinY => Raceline.Min(t => t.Position.Y);
        public float MaxY => Raceline.Max(t => t.Position.Y);
        public float MinZ => Raceline.Min(t => t.Position.Z);
        public float MaxZ => Raceline.Max(t => t.Position.Z);
    }
}
