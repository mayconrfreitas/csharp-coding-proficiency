using Xunit;
using csharp_coding_proficiency.Services;

namespace csharp_coding_proficiency.Tests.UnitTests
{
    /// <summary>
    /// Unit tests for Task 04: Analyse if the columns are rectangular.
    /// </summary>
    /// <remarks>
    /// I drew the polygons in GeoGebra: https://www.geogebra.org/calculator/byv7qbsb
    /// </remarks>
    public class Task04_AnalyseColumnRectangularTests

    {
        [Fact]
        public void TestsCheckColumnsRectangular()
        {
            // Act
            List<bool> result = Task04_AnalyseColumnRectangular.CheckColumnsRectangular();

            // Assert
            Assert.Equal(4, result.Count);
            Assert.True(result[0]); // Should be rectangular
            Assert.True(result[1]); // Should be rectangular
            Assert.True(result[2]); // Should be rectangular
            Assert.False(result[3]); // Should not be rectangular 
            
        }
    }
}