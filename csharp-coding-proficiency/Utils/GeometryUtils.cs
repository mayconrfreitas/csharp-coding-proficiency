using NetTopologySuite.Geometries;

namespace csharp_coding_proficiency.Utils
{
    public class GeometryUtils
    {
        public static Polygon CreatePolygon(double[] xValues, double[] yValues)
        {
            var coordinates = new List<Coordinate>();
            for (int i = 0; i < xValues.Length; i++)
            {
                coordinates.Add(new Coordinate(xValues[i], yValues[i]));
            }
            var ring = new LinearRing(coordinates.ToArray());
            return new Polygon(ring);
        }
        public static List<Polygon> LoadColumns()
        {
            var columns = new List<Polygon>();

            columns.Add(CreatePolygon(new[] { 2.0, 6.0, 6.0, 2.0, 2.0 }, new[] { 3.0, 3.0, 5.0, 5.0, 3.0 }));
            columns.Add(CreatePolygon(new[] { 9.0, 12.0, 10.0, 7.0, 9.0 }, new[] { 5.0, 8.0, 10.0, 7.0, 5.0 }));
            columns.Add(CreatePolygon(new[] { 17.0, 17.0, 19.0, 19.0, 17.0 }, new[] { 1.0, -3.0, -3.0, 1.0, 1.0 }));
            columns.Add(CreatePolygon(new[] { 19.0, 19.0, 24.0, 24.0, 19.0 }, new[] { 8.0, 5.0, 5.0, 6.0, 8.0 }));
            return columns;
        }
        public static Polygon LoadTerrain()
        {
            return CreatePolygon(new[] { 1.0, 28.0, 23.0, -1.0, 1.0 }, new[] { 9.0, 9.0, -6.0, -2.0, 9.0 });
        }

    }
}
