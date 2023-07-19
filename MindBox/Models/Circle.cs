using MindBoxTestQuest.Interfaces;

namespace MindBoxTestQuest.Models;

public class Circle : ICalculateArea
{
    private readonly double _radius;
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="radius">Радиус окружности</param>
    /// <exception cref="ArgumentException">Исключение на случай радиуса меньше 0 </exception>
    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException($"{radius} less than 0");
        }
        _radius = radius;
    }
    /// <summary>
    /// Рассчет площади окружности по радиусу.
    /// </summary>
    /// <returns>Площадь окружности типа Double.</returns>
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }

    
}