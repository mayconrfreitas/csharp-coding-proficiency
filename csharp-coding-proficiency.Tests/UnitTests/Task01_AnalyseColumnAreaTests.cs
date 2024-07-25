using Xunit;
using csharp_coding_proficiency.Services;

namespace csharp_coding_proficiency.Tests.UnitTests
{
    /// <summary>
    /// Unit tests for Task 01: Analyse if the area of the column is less or equals to 10m2.
    /// </summary>
    /// <remarks>
    /// I drew the polygons in GeoGebra: https://www.geogebra.org/calculator/byv7qbsb
    /// </remarks>
    public class Task01_AnalyseColumnAreaTests
    {
        [Fact]
        public void TestCheckAreaLessOrEqualsTo10m2()
        {
            // Arrange
            double maxArea = 10;

            // Act
            List<bool> result = Task01_AnalyseColumnArea.CheckAreaLessOrEquals(maxArea);

            // Assert
            Assert.Equal(4, result.Count);
            Assert.True(result[0]); // Should be 8m2
            Assert.False(result[1]); // Should be 12m2
            Assert.True(result[2]); // Should be 8m2
            Assert.True(result[3]); // Should be 10m2
        }
    }
}