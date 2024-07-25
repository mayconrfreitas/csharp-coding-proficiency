using csharp_coding_proficiency.Utils;
using NetTopologySuite.Geometries;

namespace csharp_coding_proficiency.Services
{
    /// <summary>
    ///  Task 01: Analyse all columns that have area less than or equal to 10m². 
    /// </summary>
    public static class Task01_AnalyseColumnArea
    {
        public static List<bool> CheckAreaLessOrEquals(double maxArea = 10)
        {
            // Load columns
            List<Polygon> columns = GeometryUtils.LoadColumns();

            // Variable to store the results
            List<bool> results = new List<bool>();

            foreach (Polygon column in columns)
            {
                Console.WriteLine(column.Area);
                // Use the Area property from the NetTopologySuite.Geometries.Polygon class to check the area of the column
                // https://nettopologysuite.github.io/NetTopologySuite/api/NetTopologySuite.Geometries.Polygon.html#NetTopologySuite_Geometries_Polygon_Area
                results.Add(column.Area <= maxArea);
            }

            return results;

        }
    }
}
