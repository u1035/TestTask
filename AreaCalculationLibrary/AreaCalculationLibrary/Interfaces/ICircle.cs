namespace AreaCalculationLibrary.Interfaces;

/// <summary>
/// Describes circle shape
/// </summary>
public interface ICircle : IShape {
    /// <summary>
    /// Circle radius
    /// </summary>
    public double Radius { get; }
}