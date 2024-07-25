using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_coding_proficiency.Utils;
using NetTopologySuite.Geometries;

namespace csharp_coding_proficiency.Services
{
    /// <summary>
    /// Task 03: Analyse if there is a 7m space between all columns.
    /// </summary>
    public static class Task03_AnalyseSpaceBetweenColumns
    {
        public static List<bool> CheckSpaceBetweenColumns()
        {
            // Load columns
            List<Polygon> columns = GeometryUtils.LoadColumns();
            // Variable to store the results
            List<bool> results = new List<bool>();

            for (int i = 0; i < columns.Count - 1; i++)
            {
                for (int j = i + 1; j < columns.Count; j++)
                {
                    // Use the Distance method from the NetTopologySuite.Geometries class to check the distance between the columns
                    // https://nettopologysuite.github.io/NetTopologySuite/api/NetTopologySuite.Geometries.Geometry.html#NetTopologySuite_Geometries_Geometry_Distance_NetTopologySuite_Geometries_Geometry_
                    results.Add(columns[i].Distance(columns[j]) >= 7);
                }
            }

            return results;
        }
    }
}
