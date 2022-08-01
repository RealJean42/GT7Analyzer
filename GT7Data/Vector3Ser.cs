using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GT7Data
{
    /// <summary>
    /// Serializable version of Vector3
    /// </summary>
    [Serializable]
    public class Vector3Ser
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public Vector3Ser()
        { }

        public Vector3Ser(Vector3 vec)
        {
            X= vec.X;
            Y= vec.Y;
            Z= vec.Z;
        }

        public Vector3 AsStruct()
        {
            return new Vector3
            {
                X = X,
                Y = Y,
                Z = Z
            };
        }
    }
}
