using MindBoxTestQuest.Models;

namespace FiguresTest.Figures;

[TestClass]
public class TriangleTest
{
    [TestMethod]
    [DataRow(5.0,8.0, 1.0)]
    [DataRow(1.0,3.0, 4.0)]
    public void Ctor_IncorrectSides_Exception(double firstSide, double secondSide, double thirdSide)
    {
        //Assert 
        Assert.ThrowsException<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
    }

    [TestMethod]
    public void CalculateArea_Test_Correct()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        //Act
        var result = triangle.CalculateArea();
        double totalArea = 6;
        
        //Assert
        Assert.AreEqual(totalArea, result);
    }

    [TestMethod]
    public void IsRightTriangle_PythagoreanTheorem_True()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 4;
        double thirdSide = 5;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        //Act
        var result = triangle.IsRightTriangle();
        var correctResult = true;
        
        //Assert
        Assert.AreEqual(result, correctResult);
    }
    [TestMethod]
    public void IsRightTriangle_PythagoreanTheorem_False()
    {
        //Arrange
        double firstSide = 3;
        double secondSide = 3;
        double thirdSide = 3;
        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        
        //Act
        var result = triangle.IsRightTriangle();
        var correctResult = false;
        
        //Assert
        Assert.AreEqual(result, correctResult);
    }

    
}