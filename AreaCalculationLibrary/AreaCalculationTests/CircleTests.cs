using AreaCalculationLibrary.Classes;
using FluentAssertions;

namespace AreaCalculationTests 
{
    public class CircleTests 
    {
        [Fact]
        public void Circle_NegativeRadius_ShouldThrowException() 
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1));
        }

        [Fact]
        public void Circle_CorrectRadius_ShouldReturnArea()
        {
            var circle = new Circle(1);
            var area = circle.GetArea();
            area.Should().Be(Math.PI); // Pi * 1 * 1;
        }
    }
}