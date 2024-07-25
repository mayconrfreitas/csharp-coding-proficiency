using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetTopologySuite.Geometries;
using csharp_coding_proficiency.Utils;

namespace csharp_coding_proficiency.Services
{
    /// <summary>
    /// Task 02: Analyse all columns that are inside the terrain.
    /// </summary>
    public static class Task02_AnalyseColumnsInsideTerrain
    {
        public static List<bool> CheckColumnsInsideTerrain()
        {
            // Load columns
            List<Polygon> columns = GeometryUtils.LoadColumns();
            //Load terrain
            Polygon terrain = GeometryUtils.LoadTerrain();

            // Variable to store the results
            List<bool> results = new List<bool>();

            foreach (Polygon column in columns)
            {
                // Use the Contains method from the NetTopologySuite.Geometries class to check if the column is inside the terrain
                // https://nettopologysuite.github.io/NetTopologySuite/api/NetTopologySuite.Geometries.Geometry.html#NetTopologySuite_Geometries_Geometry_Contains_NetTopologySuite_Geometries_Geometry_
                results.Add(terrain.Contains(column));
            }

            
            return results;

        }

    }
}
