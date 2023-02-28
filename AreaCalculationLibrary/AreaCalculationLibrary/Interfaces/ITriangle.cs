namespace AreaCalculationLibrary.Interfaces;

/// <summary>
/// Describes triangle shape
/// </summary>
public interface ITriangle : IShape {
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    /// <summary>
    /// Returns true if triangle is right
    /// </summary>
    public bool IsRightTriangle { get; }
}