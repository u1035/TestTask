using AreaCalculationLibrary.Classes;
using FluentAssertions;

namespace AreaCalculationTests;

public class TriangleTests {
    [Fact]
    public void Triangle_NegativeSideLength_ShouldThrowException() 
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 10, 10));
    }

    [Fact]
    public void Triangle_CorrectSideLength_ShouldReturnArea() 
    {
        var triangle = new Triangle(5, 7, 9);
        var area = triangle.GetArea();
        area.Should().BeApproximately(17.4123, 4);
    }

    [Fact]
    public void Triangle_NotRightTriangle_ShouldReturnFalse()
    {
        var triangle = new Triangle(5, 7, 95);
        triangle.IsRightTriangle.Should().BeFalse();
    }
    
    [Fact]
    public void Triangle_RightTriangle_ShouldReturnTrue()
    {
        var triangle = new Triangle(3,4,5);
        triangle.IsRightTriangle.Should().BeTrue();
    }
}