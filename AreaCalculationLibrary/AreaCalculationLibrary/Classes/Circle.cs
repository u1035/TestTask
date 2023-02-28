using System;
using AreaCalculationLibrary.Interfaces;

namespace AreaCalculationLibrary.Classes {
    /// <summary>
    /// Implementation of <see cref="ICircle"/>
    /// </summary>
    public class Circle : ICircle {
        /// <inheritdoc />
        public double Radius { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="Circle"/>
        /// </summary>
        /// <param name="radius"></param>
        public Circle(double radius) {
            if (radius < 0)
                throw new ArgumentException("Circle radius should be greater than zero");

            Radius = radius;
        }

        /// <inheritdoc />
        public double GetArea() => Math.PI * (Radius * Radius);
    }
}
