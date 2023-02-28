using System;
using AreaCalculationLibrary.Interfaces;

namespace AreaCalculationLibrary.Classes;

/// <summary>
/// Implementation of <see cref="ITriangle"/>
/// </summary>
public class Triangle : ITriangle {
    /// <inheritdoc />
    public double SideA { get; }

    /// <inheritdoc />
    public double SideB { get; }

    /// <inheritdoc />
    public double SideC { get; }

    /// <inheritdoc />
    public bool IsRightTriangle { get; }

    /// <summary>
    /// Initializes a new instance of <see cref="Triangle"/>
    /// </summary>
    /// <param name="sideA"></param>
    /// <param name="sideB"></param>
    /// <param name="sideC"></param>
    public Triangle(double sideA, double sideB, double sideC) {
        if (sideA < 0 || sideB < 0 || sideC < 0)
            throw new ArgumentException("Triangle sides should be greater than zero");

        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
        IsRightTriangle = CheckIsRightTriangle();
    }

    private bool CheckIsRightTriangle() {
        //if triangle is right - it must match Pythagorean theorem
        return ((SideA * SideA) + (SideB * SideB)).Equals(SideC * SideC) ||
               ((SideA * SideA) + (SideC * SideC)).Equals(SideB * SideB) ||
               ((SideB * SideB) + (SideC * SideC)).Equals(SideA * SideA);
    }

    /// <inheritdoc />
    public double GetArea() {
        //Herone's formula description: https://calculat.ru/ploshhad-treugolnika-po-trem-storonam-po-formule-gerona
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }
}