using FluentAssertions;
using Model;
using Xunit;

namespace UnitTests;

public class NullabilityTests
{
    [Fact]
    public void TestCageVolumteer()
    {
        var cage = new Cage() { Number = 1, Volunteer = new Volunteer() {Name = "Test"}};

        var result = cage.ToString();

        result.Should().Be("Cage 1 Test");
    }
    
    [Fact]
    public void TestCageWithoutVolumteer()
    {
        var cage = new Cage() { Number = 1, Volunteer = new Volunteer()};

        var result = cage.ToString();

        result.Should().Be("Cage 1 No Volunteer");
    }
    
    
}