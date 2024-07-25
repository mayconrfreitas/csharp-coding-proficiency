using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;

namespace csharp_coding_proficiency.Models
{
    public class Vector
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector(Coordinate startPoint, Coordinate endPoint)
        {
            X = endPoint.X - startPoint.X;
            Y = endPoint.Y - startPoint.Y;
        }

        public double DotProduct(Vector vector)
        {
            return X * vector.X + Y * vector.Y;
        }

        public double Magnitude()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
