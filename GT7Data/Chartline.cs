using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace GT7Data
{
    public enum DataType
    {
        None,
        Speed,
        Throttle,
        Brake
    }

    public class Chartline
    {
        public string LapId { get; set; }
        public Color LineColor { get; set; } = Color.White;
        public List<float> Samples { get; set; } = new List<float>();
        public DataType Type { get; set; } = DataType.Speed;

        /// <summary>
        /// Factor to use to convert float to pixel
        /// e.g. 1.0 = 100 pixel => Scale=100.0f
        /// Default: 1.0f
        /// </summary>
        public float PixelScale { get; set; } = 1.0f;
        public int GetSampleConverted(int index)
        {
            if(index<0 || index>Samples.Count-1)
            {
                return 0;
            }
            return Convert.ToInt32(Samples[index] * PixelScale);
        }
    }
}
