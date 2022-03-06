using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ConsoleAppProject.App02;

namespace ConsoleAppTests
{
    [TestClass]
    public class BMITest
    {
        [TestMethod]
        public void MetricTest()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.524;
            converter.kilogram = 45.5;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result,0));
        }

        [TestMethod]
        public void MetricTest2()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.549;
            converter.kilogram = 47.1;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest3()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.574;
            converter.kilogram = 50;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest4()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.60;
            converter.kilogram = 52.3;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest5()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.625;
            converter.kilogram = 54.5;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest6()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.651;
            converter.kilogram = 56.8;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest7()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.676;
            converter.kilogram = 59.1;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest8()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.701;
            converter.kilogram = 61.4;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest9()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.727;
            converter.kilogram = 63.6;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest10()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.745;
            converter.kilogram = 64.9;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }


        [TestMethod]
        public void MetricTest11()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.778;
            converter.kilogram = 68.2;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 22;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest12()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.803;
            converter.kilogram = 70.5;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 22;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void MetricTest13()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Metric;

            converter.meter = 1.828;
            converter.kilogram = 72.7;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 22;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }



        [TestMethod]
        public void ImpericalTest()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;

            
            converter.inch = 60;
            converter.pound = 100;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest2()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.08333333;
            converter.pound = 105;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 20;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest3()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.1666667;
            converter.pound = 110;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 21;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest4()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.25;
            converter.pound = 115;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 22;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest5()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.3333333;
            converter.pound = 120;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 23;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest6()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.4166667;
            converter.pound = 125;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 24;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest7()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.5;
            converter.pound = 130;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 25;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }


        [TestMethod]
        public void ImpericalTest8()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.5833333;
            converter.pound = 135;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 26;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest9()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.6666667;
            converter.pound = 140;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 27;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest10()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.75;
            converter.pound = 145;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 28;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

        [TestMethod]
        public void ImpericalTest11()
        {
            BMI converter = new BMI();

            converter.unit = BMI.Unit.Imperical;


            converter.inch = 60.08333333;
            converter.pound = 150;

            double result = converter.BMICalculation(converter.unit);
            double expectedDistance = 29;
            Assert.AreEqual(expectedDistance, Math.Round(result, 0));
        }

    }
}

