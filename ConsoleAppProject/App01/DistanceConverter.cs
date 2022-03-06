using System;
using ConsoleAppProject.Helpers;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Allows the user to convert distances measured in one unit of distance into another unit of choice.
    /// </summary>
    /// <author>
    /// Kyle Whynn 
    /// </author>
    public class DistanceConverter
    {
        /// <summary>
        /// Constants for conversions
        /// </summary>
        public const int FEET_IN_MILES = 5280;
        public const double METRES_IN_MILES = 1609.34;
        public const double FEET_IN_METERS = 3.280;
        public 

        /// <summary>
        /// Varibale for number inputs
        /// </summary>
        string value;

        /// <summary>
        ///  Variables to store distance value
        /// </summary>
        public double FromDistance;
        public double ToDistance;

        /// <summary>
        /// Variables for user selected units
        /// </summary>
        public DistanceUnits FromUnit;
        public DistanceUnits ToUnit;

        /// <summary>
        /// Enum for distance units
        /// </summary>
        public enum DistanceUnits
        {
            NoUnit,
            Feet=1,
            Meter,
            Mile
        }

        /// <summary>
        /// used to run program
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("App01 Distance Converter");

            CheckUnit(FromUnit = SelectUnit(" Please select your from unit"));

            CheckUnit(ToUnit = SelectUnit(" Please select your to unit"));

            FromDistance = ConsoleHelper.InputNumber($" Please enter the distance in {FromUnit} > ");

            ConvertDistance();

            OutputDistance();
        }

        /// <summary>
        ///  USed to allow user to select units
        /// </summary>
        private DistanceUnits SelectUnit(string prompt)
        {
            Console.WriteLine(prompt);
            Console.WriteLine();

            Console.WriteLine($" 1. {DistanceUnits.Mile}");
            Console.WriteLine($" 2. {DistanceUnits.Feet}");
            Console.WriteLine($" 3. {DistanceUnits.Meter}");

            Console.WriteLine();
            Console.Write(" Please enter choice > ");

            string choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                return DistanceUnits.Mile;
            }
            else if (choice == "2")
            {
                return DistanceUnits.Feet;
            }
            else if (choice == "3")
            {
                return DistanceUnits.Meter;
            }
            else return DistanceUnits.NoUnit;

        }

        /// <summary>
        /// Outputs distance to user
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {FromDistance} {FromUnit} = {ToDistance}  {ToUnit}s!");
        }

        /// <summary>
        ///  COnverts the distance to user defined unit
        /// </summary>
       public void ConvertDistance()
        {
            if (FromUnit == DistanceUnits.Mile &&
               ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Feet &&
                     ToUnit == DistanceUnits.Mile)
            {
                ToDistance = FromDistance / FEET_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Meter &&
                      ToUnit == DistanceUnits.Mile)
            {
                ToDistance = FromDistance / METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Mile &&
                     ToUnit == DistanceUnits.Meter)
            {
                ToDistance = FromDistance * METRES_IN_MILES;
            }
            else if (FromUnit == DistanceUnits.Meter &&
                    ToUnit == DistanceUnits.Feet)
            {
                ToDistance = FromDistance * FEET_IN_METERS;
            }
            else if (FromUnit == DistanceUnits.Feet &&
                    ToUnit == DistanceUnits.Meter)
            {
                ToDistance = FromDistance / FEET_IN_METERS;

            }
            else if (FromUnit == ToUnit) 
            {
                ToDistance = FromDistance;
            }
        }
    
        /// <summary>
        ///  Used to vvalidate unit input.
        /// </summary>
        private DistanceUnits CheckUnit(DistanceUnits unit )
        {

            while (unit == DistanceUnits.NoUnit)
            {

                if (unit == DistanceUnits.NoUnit)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Your Input is invalid");
                    unit = SelectUnit(" Try Again");

                }

            }

            return unit;

        }
    }
}