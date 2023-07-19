using MindBoxTestQuest.Interfaces;

namespace MindBoxTestQuest.Models;

public class Triangle : ICalculateArea
{
    private readonly double _firstSide;
    private readonly double _secondSide;
    private readonly double _thirdSide;
    /// <summary>
    /// .ctor
    /// </summary>
    /// <param name="firstSide">Сторона 1</param>
    /// <param name="secondSide">Сторона 2</param>
    /// <param name="thirdSide">Сторона 3</param>
    /// <exception cref="ArgumentException">Исключение срабатывает в случае если хотя бы одна из сторон меньше 0
    /// или в случае нарушения правила существования треугольника (сумма длин двух сторон меньше длины третьей).</exception>
    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if(firstSide<0 && secondSide<0 && thirdSide<0)
        {
            throw new ArgumentException($"Side cannot be less than 0");
        }

        if (firstSide + secondSide > thirdSide && secondSide + thirdSide > firstSide &&
            firstSide + thirdSide > secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;
        }
        else
        {
            throw new ArgumentException("The triangle with such sides cannot exist");
        }
    }
    /// <summary>
    /// Рассчет площади по 3 сторонам.
    /// </summary>
    /// <returns>
    /// Возвращает значение с плавающей точкой.
    /// </returns>
    public double CalculateArea()
    {
        var halfPerimeter = (_firstSide + _secondSide + _thirdSide) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - _firstSide) * (halfPerimeter - _secondSide) *
                         (halfPerimeter - _thirdSide));
    }
    /// <summary>
    /// Проверка, является ли треугольник прямоугольным, первая проверка отсеивает односторонние треугольники
    /// если треугольник не разносторонний, создается список со сторонами, выбирается максимальное значение, после чего записывается
    /// в отдельную переменную и удаляется из списка. Остальные значения списка возводятся в квадртат, суммируются и сравниваются с квадратом третьей стороны.
    /// </summary>
    /// <returns></returns>
    public bool IsRightTriangle()
    {
        if(_firstSide == _secondSide && _secondSide==_thirdSide && _firstSide==_thirdSide )
        {
            return false;
        }
        else
        {
            var sidesList = new List<double> {_firstSide, _secondSide, _thirdSide };
            var maxSide = sidesList.Max();
            sidesList.Remove(maxSide);
            return sidesList.Select(p => Math.Pow(p, 2)).Sum().Equals(Math.Pow(maxSide, 2));
        }
    }
}