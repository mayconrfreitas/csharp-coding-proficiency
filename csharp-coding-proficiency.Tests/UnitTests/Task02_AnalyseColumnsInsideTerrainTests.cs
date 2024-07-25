using Xunit;
using csharp_coding_proficiency.Services;

namespace csharp_coding_proficiency.Tests.UnitTests
{
    /// <summary>
    /// Unit tests for Task 02: Analyse if the columns are inside the terrain.
    /// </summary>
    /// <remarks>
    /// I drew the polygons in GeoGebra: https://www.geogebra.org/calculator/byv7qbsb
    /// </remarks>
    public class Task02_AnalyseColumnsInsideTerrainTests
    {
        [Fact]
        public void TestCheckColumnsInsideTerrain()
        {
            // Act
            List<bool> result = Task02_AnalyseColumnsInsideTerrain.CheckColumnsInsideTerrain();

            // Assert
            Assert.Equal(4, result.Count);
            Assert.True(result[0]); // Should be inside the terrain
            Assert.False(result[1]); // Should be outside the terrain
            Assert.True(result[2]); // Should be inside the terrain
            Assert.True(result[3]); // Should be inside the terrain
            
        }
    }
}