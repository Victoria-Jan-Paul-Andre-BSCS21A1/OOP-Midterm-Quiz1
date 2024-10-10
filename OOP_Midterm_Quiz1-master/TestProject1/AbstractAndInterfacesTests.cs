using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ClassLibrary1;

namespace TestProject1
{
    [TestClass]
    public class AbstractAndInterfacesTests
    {
        [TestMethod]
        [ExpectedException(typeof(MissingMethodException))]
        public void AbstractShape_Should_Throw_Exception_When_Instantiated()
        {
            // Act & Assert
            Shape shape = (Shape)Activator.CreateInstance(typeof(Shape), true);
        }

        [TestMethod]
        public void Circle_Should_Override_AbstractMethods_Correctly()
        {
            // Arrange
            Circle circle = new Circle { Radius = 3 };

            // Act
            var area = circle.Area();

            // Assert
            Assert.AreEqual(28.2743, area, 0.0001);
        }

        [TestMethod]
        public void Rectangle_Should_Override_AbstractMethods_Correctly()
        {
            // Arrange
            ClassLibrary1.Rectangle rectangle = new ClassLibrary1.Rectangle { Width = 5, Height = 2 };

            // Act
            var area = rectangle.Area();

            // Assert
            Assert.AreEqual(10, area);
        }
    }
}

