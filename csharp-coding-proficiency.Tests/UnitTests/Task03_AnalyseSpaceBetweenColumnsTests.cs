using Xunit;
using csharp_coding_proficiency.Services;

namespace csharp_coding_proficiency.Tests.UnitTests
{
    /// <summary>
    /// Unit tests for Task 03: Analyse if there is a 7m space between all columns.
    /// </summary>
    /// <remarks>
    /// I drew the polygons in GeoGebra: https://www.geogebra.org/calculator/byv7qbsb
    /// </remarks>
    public class Task03_AnalyseSpaceBetweenColumnsTests

    {
        [Fact]
        public void TestCheckSpaceBetweenColumns()
        {
            // Act
            List<bool> result = Task03_AnalyseSpaceBetweenColumns.CheckSpaceBetweenColumns();

            // Assert
            Assert.Equal(6, result.Count);
            Assert.False(result[0]); // Should be +/- 2.12
            Assert.True(result[1]); // Should be +/- 11.18
            Assert.True(result[2]); // Should be +/- 13.11
            Assert.True(result[3]); // Should be +/- 8.49
            Assert.True(result[4]); // Should be +/- 7.02
            Assert.False(result[5]); // Should be +/- 4.13
            
        }
    }
}