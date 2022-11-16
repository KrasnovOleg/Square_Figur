using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square_Figure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Figure.Tests
{
    [TestClass()]
    public class ShapesTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            double x = 3;
            double expected = 9.42;

            Shapes c = new Shapes();
            double actual = c.Circle(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void boxTest()
        {
            double x = 3;
            double y = 3;
            double expected = 9;

            Shapes c = new Shapes();
            double actual = c.box(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void boxTest2()
        {
            double x = 3;
            double y = 4;
            double expected = 12;

            Shapes c = new Shapes();
            double actual = c.box(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Triangle_rectangular_Test()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;

            Shapes c = new Shapes();
            double actual = c.Triangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Triangle_isosceles_Test()
        {
            double x = 3;
            double y = 3;
            double z = 3;
            double expected = 3.897;

            Shapes c = new Shapes();
            double actual = c.Triangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Triangle_error_Test()
        {
            double x = 1;
            double y = 1;
            double z = 9;
            double expected = 0;

            Shapes c = new Shapes();
            double actual = c.Triangle(x, y, z);

            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void Figure_Circle_Test()
        {
            double x = 3;
            double expected = 9.42;

            Shapes c = new Shapes();
            double actual = c.Figure(x);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Figure_box_Test()
        {
            double x = 3;
            double y = 3;
            double expected = 9;

            Shapes c = new Shapes();
            double actual = c.Figure(x, y);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Figure_box2_Test()
        {
            double x = 3;
            double y = 4;
            double expected = 12;

            Shapes c = new Shapes();
            double actual = c.Figure(x, y);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void Figure_Triangle_Test()
        {
            double x = 3;
            double y = 4;
            double z = 5;
            double expected = 6;

            Shapes c = new Shapes();
            double actual = c.Figure(x, y, z);

            Assert.AreEqual(expected, actual);
        }

        public void Figure_Triangle_isosceles_Test()
        {
            double x = 3;
            double y = 3;
            double z = 3;
            double expected = 3.897;

            Shapes c = new Shapes();
            double actual = c.Figure(x, y, z);

            Assert.AreEqual(expected, actual);
        }
    }
}