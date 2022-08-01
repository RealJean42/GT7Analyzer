using System;

namespace GT7Data
{
    public class TrackPosition
    {
        public TimeSpan Timestamp { get; set; }

        /// <summary>
        /// Units: meter
        /// </summary>
        public Vector3Ser Position { get; set; } = new Vector3Ser();

    }
}
