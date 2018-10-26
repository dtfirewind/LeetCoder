using Xunit;
using System;
using LeetCoder.Domain;

namespace LeetCoder.Test
{
    public class DistinctIslandTest
    {
        DistinctIsland test = new DistinctIsland();

        [Fact]
        public void WhenEmptyGridReturn0()
        {
        //Given
            var expected = 0;
            int[,] grid = new int[0,0];
        //When
            int result = test.GetIslandCount(grid);
        //Then
            Assert.Equal(expected,result);
        }
    }
}