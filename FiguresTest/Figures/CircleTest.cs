using MindBoxTestQuest.Interfaces;
using MindBoxTestQuest.Models;
using Moq;

namespace FiguresTest.Figures;

[TestClass]
public class CircleTest
{
    [TestMethod]
    [DataRow(0)]
    public void Ctor_IncorrectRadius_Exception(double radius)
    {
        //Assert
        Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
    }
    
    [TestMethod]
    public void CalculateArea_Test_Correct()
    {
        //Arrange
        double radius = 31;
        var circle = new Circle(radius);
        
        //Act
        var result = circle.CalculateArea();
        var totalArea = Math.PI * Math.Pow(radius, 2);
        
        //Assert
        Assert.AreEqual(totalArea, result);
    }
}