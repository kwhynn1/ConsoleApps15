using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppTests
{
    [TestClass]
    public class DCTest
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Mile;
            converter.ToUnit = DistanceConverter.DistanceUnits.Feet;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 5280;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Feet;
            converter.ToUnit = DistanceConverter.DistanceUnits.Mile;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 0.0001893939393939394;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMeterToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Meter;
            converter.ToUnit = DistanceConverter.DistanceUnits.Mile;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 0.0006213727366498068;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMilesToMeter()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Mile;
            converter.ToUnit = DistanceConverter.DistanceUnits.Meter;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 1609.34;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestMeterToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Meter;
            converter.ToUnit = DistanceConverter.DistanceUnits.Feet;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 3.28;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

        [TestMethod]
        public void TestFeetToMeter()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceConverter.DistanceUnits.Feet;
            converter.ToUnit = DistanceConverter.DistanceUnits.Meter;

            converter.FromDistance = 1;
            converter.ConvertDistance();

            double expectedDistance = 0.3048780487804878;

            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }

    }
}

