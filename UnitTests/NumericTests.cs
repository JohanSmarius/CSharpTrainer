using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace UnitTests;

public class NumericTests
{
    [Fact]
    public void Calculate_Min()
    {
        var minValue = CreateList().Min();
        
        Assert.Equal(1, minValue);
    }

    [Fact]
    public void Calculate_Sum()
    {
        var result = CreateList().Sum();
        
        Assert.Equal(37, result);
    }

    [Fact]
    public void CalculateAverageForNumbersSmallerThan5()
    {
        var average = CreateList().Where(n => n < 5).Average();
        
        Assert.Equal((7d/3), average);
    }

    private List<int> CreateList()
    {
        return new()
        {
            1, 2, 4, 5, 7, 8, 10
        };
    }
}