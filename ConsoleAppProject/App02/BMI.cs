using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Allows the user to calculate thier BMI.
    /// </summary>
    /// <author>
    /// Kyle Whynn 
    /// </author>

    public class BMI
    {
        /// <summary>
        /// Varibales to used in the app
        /// </summary>
        public const double FEET_IN_INCHES = 12;
        public const double POUND_IN_STONES = 14;
        public double stone;
        public double pound;
        public double feet;
        public double inch;
        public double kilogram;
        public double meter;
        public double convertedFeet;
        public double convertedStones;
        public double bmi;
        public WeightStatus weight;
        public  Unit unit;
        public double result;


        /// <summary>
        /// Enum forUnits
        /// </summary>
        public enum Unit 
        {
            NoUnit,
            Imperical,
            Metric
        }

        /// <summary>
        /// enum for Weight Status
        /// </summary>
        public enum WeightStatus
        {
            Underweight,
            Normal,
            Overweight,
            ObeseClassI,
            ObeseClassII,
            ObeseClassIII,
            NoStatus
        }

        /// <summary>
        /// used to run program
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App02 BMI Calculator");
            unit = SelectUnit();
            result = BMICalculation(unit);
            Console.WriteLine(inch);
            OutputBMI();
        }

        /// <summary>
        /// Used to select the unit
        /// </summary>
        /// 
        private Unit SelectUnit()
        {

            Console.WriteLine();

            Console.WriteLine($" 1. Imperical Units");
            Console.WriteLine($" 2. Metric Units");

            Console.WriteLine();
            Console.Write($" Please enter choice > ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            while (choice != "1" || choice != "2")
            {
                if (choice == "1")
                {
                    feet = ConsoleHelper.InputNumber("Enter Your Height In Feet >");
                    inch = ConsoleHelper.InputNumber("Enter Your Height In Inches >");
                    convertedFeet = inch * FEET_IN_INCHES;
                    inch = inch + convertedFeet;
                    pound = ConsoleHelper.InputNumber("Enter Your Weight In Pounds >");
                    stone = ConsoleHelper.InputNumber("Enter Your Weight In Stones >");
                    convertedStones = stone * POUND_IN_STONES;
                    pound = pound + convertedStones;
                    return Unit.Imperical;

                }
                else if (choice == "2")
                {
                    meter = ConsoleHelper.InputNumber("Enter Your Height In Metres >");
                    kilogram = ConsoleHelper.InputNumber("Enter Your Weight In Kilograms >");
                    return Unit.Metric;
                }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine(" Invalid Input");
                    Console.WriteLine(" Try Again");
                    Console.WriteLine();

                    Console.WriteLine($" 1. Imperical Units");
                    Console.WriteLine($" 2. Metric Units");

                    Console.WriteLine();
                    Console.Write($" Please enter choice > ");

                    choice = Console.ReadLine();
                    Console.WriteLine();
                }
            
            }

            return Unit.NoUnit;
        }

        /// <summary>
        ///  Used to calculate the BMI
        /// </summary>
        public double BMICalculation (Unit unit) 
        {

            if (unit == Unit.Imperical)

            {
                bmi = pound / (inch*inch) * 703;
            } 
            else if (unit == Unit.Metric)
            {
                bmi = kilogram / (meter * meter);
            }
            return bmi;
        }

        /// <summary>
        ///  Used to return the enums for Weight Status
        /// </summary>
        private WeightStatus WStatus() 
        {
            if (bmi < 18.50) 
            {
                return WeightStatus.Underweight;
            }
            else if (bmi > 18.5 || bmi >24.9)
            { 
                return WeightStatus.Normal; 
            }
            else if (bmi > 25 || bmi > 29.9)
            {
                return WeightStatus.Overweight;
            }
            else if (bmi > 30 || bmi > 34.9)
            {
                return WeightStatus.ObeseClassI;
            }
            else if (bmi > 35 || bmi > 39.9)
            {
                return WeightStatus.ObeseClassII;
            }
            else if (bmi >= 40)
            {
                return WeightStatus.ObeseClassIII;
            }

            return WeightStatus.NoStatus;
        }

        /// <summary>
        /// Outputs the  results of BMI claculation
        /// </summary>
        private void OutputBMI ()
        {
            Console.WriteLine();
            Console.WriteLine($"Your BMI is {bmi}, You are in the { WStatus()} range!");
            Console.WriteLine();

            Console.WriteLine("If you are Black, Asian or other minority ethnic groups, you have a higher risk");
            Console.WriteLine();
            Console.WriteLine("Adults 23.00 or more are at an increased risk");
            Console.WriteLine();
            Console.WriteLine("Adults 27.5 or more are at a high risk");

        }

    }

}
