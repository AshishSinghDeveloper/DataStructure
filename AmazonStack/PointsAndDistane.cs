using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AmazonStack
{
    public class PointsAndDistane : IComparable<PointsAndDistane>
    {
        public int x { get; set; }
        public int y { get; set; }
        public double distance { get; set; }

        public int CompareTo(PointsAndDistane other)
        {
            if (other == null)
                return 1;
            else
                return this.distance.CompareTo(other.distance);
        }
    }
}
