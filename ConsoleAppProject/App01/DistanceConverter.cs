using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Allows the user to convert distances measured in one unit of distance into another unit of distance
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

        /// <summary>
        /// Varibale for number inputrs
        /// </summary>
        string value;

        /// <summary>
        ///  Variables to store distance value
        /// </summary>
        private double fromDistance;
        private double toDistance;
        private double Distance;

        /// <summary>
        /// Variable used for data validation
        /// </summary>
        private bool checkDistance;

        /// <summary>
        /// Variables for user selected units
        /// </summary>
        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;

        /// <summary>
        /// Enum for distance units
        /// </summary>
        public enum DistanceUnits
        {
            NoUnit,
            Feet,
            Meter,
            Mile
        }

        /// <summary>
        /// used to run program
        /// </summary>
        public void Run()
        {
            OutputHeading();

            CheckUnit(fromUnit = SelectUnit(" Please select your from unit"));

            CheckUnit(toUnit = SelectUnit(" Please select your to unit"));

            fromDistance = InputDistance($" Please enter the distance in {fromUnit} > ");

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
        /// Outs a heading to user
        /// </summary>
        private static void OutputHeading()
        {

            Console.WriteLine();
            Console.WriteLine(" ==============================");
            Console.WriteLine("    App01 Distance Converter   ");
            Console.WriteLine("            by Kyle Whynn           ");
            Console.WriteLine(" ==============================");
            Console.WriteLine();
        }

        /// <summary>
        /// Outputs distance to user
        /// </summary>
        private void OutputDistance()
        {
            Console.WriteLine($" {fromDistance} {fromUnit} = {toDistance}  {toUnit}s!");
        }

        /// <summary>
        ///  COnverts the distance to user defined unit
        /// </summary>
        private void ConvertDistance()
        {
            if (fromUnit == DistanceUnits.Mile &&
               toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                     toUnit == DistanceUnits.Mile)
            {
                toDistance = fromDistance / FEET_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Meter &&
                      toUnit == DistanceUnits.Mile)
            {
                toDistance = fromDistance / METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Mile &&
                     toUnit == DistanceUnits.Meter)
            {
                toDistance = fromDistance * METRES_IN_MILES;
            }
            else if (fromUnit == DistanceUnits.Meter &&
                    toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * FEET_IN_METERS;
            }
            else if (fromUnit == DistanceUnits.Feet &&
                    toUnit == DistanceUnits.Meter)
            {
                toDistance = fromDistance / FEET_IN_METERS;

            }
            else if (fromUnit == toUnit) 
            {
                toDistance = fromDistance;
            
            }
        }

        /// <summary>
        /// USe to get distance input from user
        /// </summary>
        private double InputDistance(string prompt)
        {
            while (checkDistance != true || Distance < 0)
            {
                Console.WriteLine();
                Console.Write(prompt);
                value = Console.ReadLine();
                Console.WriteLine();

                checkDistance = double.TryParse(value, out Distance);

                if (checkDistance == true)
                {
                    Distance = Convert.ToDouble(value);
                }

                if (checkDistance != true || Distance < 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Your Input is invalid");
                    Console.WriteLine(" Try Again");
                    Console.WriteLine();

                }
            }
            return Distance;
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