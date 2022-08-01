using System;

namespace GT7Data
{
    public class Raceline : TrackPosition
    { 
        /// <summary>
        /// Units: meter
        /// </summary>
        public Vector3Ser? Velocity { get; set; } = new Vector3Ser();

        /// <summary>
        /// Speed meters/second
        /// * 3.6 to get km/h
        /// </summary>
        public float SpeedMS { get; set; }
    }
}
