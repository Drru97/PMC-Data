using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC_Lib;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddPointToPosition()
        {
            Point1D<int> p1 = new Point1D<int>(5);
            Position1D<int> pos1 = new Position1D<int>();
            pos1.AddPoint(p1);
            Assert.AreEqual(p1.X, pos1.Points[0].X);

            Point2D<double> p2 = new Point2D<double>(2.5, 1.25);
            Position2D<double> pos2 = new Position2D<double>();
            pos2.AddPoint(p2);
            Assert.AreEqual(p2.X, pos2.Points[0].X);
            Assert.AreEqual(p2.Y, pos2.Points[0].Y);

            Point3D<decimal> p3 = new Point3D<decimal>(1.2m, 2.4m, 3.6m);
            Position3D<decimal> pos3 = new Position3D<decimal>();
            pos3.AddPoint(p3);
            Assert.AreEqual(p3.X, pos3.Points[0].X);
            Assert.AreEqual(p3.Y, pos3.Points[0].Y);
            Assert.AreEqual(p3.Z, pos3.Points[0].Z);
        }
    }
}
