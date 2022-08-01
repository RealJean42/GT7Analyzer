using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GT7Data
{
    public class Telemetry : Raceline
    {
        public int CarCode { get; set; }
        public int Lap { get; set; }
        public int Throttle { get; set; }
        public int Brake { get; set; }
        public int Gear { get; set; }

        public float Steering { get; set; }
        public float EngineRPM { get; set; }


        /// <summary>
        /// How fast the car turns around axes. (In radians/second, -1 to 1).
        /// </summary>
        public Vector3Ser AngularVelocity { get; set; } = new Vector3Ser();

        /// <summary>
        /// in Grad celcius
        /// </summary>
        public float TireTemp_FL { get;set;}

        /// <summary>
        /// in Grad celcius
        /// </summary>
        public float TireTemp_FR { get; set; }
        /// <summary>
        /// in Grad celcius
        /// </summary>
        public float TireTemp_RL { get; set; }
        /// <summary>
        /// in Grad celcius
        /// </summary>
        public float TireTemp_RR { get; set; }
    }
}
