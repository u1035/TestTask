namespace AreaCalculationLibrary.Interfaces;

/// <summary>
/// Classes that implement this interface can return area calculations data
/// </summary>
public interface IShape {
    /// <summary>
    /// Returns area of shape
    /// </summary>
    /// <returns></returns>
    public double GetArea();
}