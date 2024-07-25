using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_coding_proficiency.Utils;
using csharp_coding_proficiency.Models;
using NetTopologySuite.Geometries;

namespace csharp_coding_proficiency.Services
{
    /// <summary>
    /// Task 04: Analyse all columns that are rectangular. Do not use Polygon.IsRectangular property for this. 
    /// </summary>
    public static class Task04_AnalyseColumnRectangular
    {
        private static bool IsRectangular(Polygon column, double tolerance = 0.0001)
        {
            // Get the coordinates of the column
            Coordinate[] coordinates = column.Coordinates;
            // Check if the column has 5 coordinates (4 for the rectangle and 1 to close the polygon, should be the same as the first one)
            if (coordinates.Length != 5)
            {
                return false;
            }

            for (int i = 0; i < 4; i++)
            {
                // ChatGPT helped in the following code:

                // Get the vector between the current point and the next one
                Vector vector = new Vector(coordinates[i], coordinates[i + 1]);
                // Get the vector between the next point and the one after that one
                Vector nextVector = new Vector(coordinates[i + 1], coordinates[(i + 2) % 4]);
                // Calculate the dot product between the two vectors
                double dotProduct = vector.DotProduct(nextVector);
                // Calculate the magnitude of the two vectors
                double magnitude = vector.Magnitude() * nextVector.Magnitude();
                // Calculate the angle between the two vectors
                double angle = Math.Acos(dotProduct / magnitude);
                // Check if the angle is close to 90 degrees
                if (Math.Abs(angle - Math.PI / 2) > tolerance)
                {
                    return false;
                }
            }

            return true;
        }


        public static List<bool> CheckColumnsRectangular()
        {
            // Load columns
            List<Polygon> columns = GeometryUtils.LoadColumns();
            // Variable to store the results
            List<bool> results = new List<bool>();

            foreach (Polygon column in columns)
            {
                results.Add(IsRectangular(column));
            }

            return results;

        }
    }
}
