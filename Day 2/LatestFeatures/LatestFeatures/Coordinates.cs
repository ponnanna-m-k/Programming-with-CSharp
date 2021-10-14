using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatestFeatures
{
    public struct Coordinates
    {
        public Coordinates(Double x, Double y)
        {
            X = x;
            Y = y;
        }
        public double X { get; }
        public double Y { get; }
    }
}
