using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathLib;

namespace MathLibTests
{
    [TestClass]
    public class Geometry_Tests
    {
        [TestMethod]
        public void AreaCircle()
        {
            var result = Geometry.AreaCircle(10);
            Assert.AreEqual(Math.PI * 100, result);
        }

        [TestMethod]
        public void AreaSquare()
        {
            var result = Geometry.AreaSquare(10);
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void AreaRectangle()
        {
            var result = Geometry.AreaRectangle(10, 20);
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void AreaCircleSegment()
        {
            var result = Geometry.AreaCircleSegment(10, 90);
            Assert.AreEqual(Math.PI * 25, result);
        }

        [TestMethod]
        public void AreaTriangle()
        {
            var result = Geometry.AreaTriangle(10, 20, 45);
            Assert.AreEqual(70.71067812, Math.Round(result, 8));
        }

        [TestMethod]
        public void VolumeCube()
        {
            var result = Geometry.VolumeCube(10);
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void VolumeCylinder()
        {
            var result = Geometry.VolumeCylinder(10, 20);
            Assert.AreEqual(Math.Round(Math.PI * 2000, 8), Math.Round(result, 8));
        }

        [TestMethod]
        public void VolumeSphere()
        {
            var result = Geometry.VolumeSphere(10);
            Assert.AreEqual(Math.Round(Math.PI *  1000 * 4.0 / 3.0, 8), Math.Round(result, 8));
        }

        [TestMethod]
        public void VolumeRectBlock()
        {
            var result = Geometry.VolumeRectBlock(10, 20, 30);
            Assert.AreEqual(6000, result);
        }

        [TestMethod]
        public void VolumeCone()
        {
            var result = Geometry.VolumeCone(10, 20);
            Assert.AreEqual(Math.Round(Math.PI * 2000 / 3.0, 8), Math.Round(result, 8));
        }

        [TestMethod]
        public void PerimeterSquare()
        {
            var result = Geometry.PerimeterSquare(10);
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void PerimeterRectangle()
        {
            var result = Geometry.PerimeterRectangle(10, 20);
            Assert.AreEqual(60, result);
        }

        [TestMethod]
        public void CircumferenceCircle()
        {
            var result = Geometry.CircumferenceCircle(10);
            Assert.AreEqual(Math.Round(Math.PI * 20, 8), Math.Round(result, 8));
        }

        [TestMethod]
        public void SurfaceAreaCube()
        {
            var result = Geometry.SurfaceAreaCube(10);
            Assert.AreEqual(600, result);
        }

        [TestMethod]
        public void SurfaceAreaRectBlock()
        {
            var result = Geometry.SurfaceAreaRectBlock(10, 20, 30);
            Assert.AreEqual(2200, result);
        }

        [TestMethod]
        public void SurfaceAreaSphere()
        {
            var result = Geometry.SurfaceAreaSphere(10);
            Assert.AreEqual(Math.Round(Math.PI * 1000 * 4, 8), Math.Round(result, 8));
        }
    }
}
