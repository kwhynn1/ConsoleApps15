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
        /// Variables declared for classes
        /// </summary>
        public const int MILES_IN_FEET = 5280;
        public const double MILES_IN_METERS = 1609.34;
        public const double FEET_IN_METERS = 3.2808;
        private double miles;
        private double feet;
        private double meters;
        private string value;
        private bool check;
        private int convertfrom;
        private int convertto;

        public enum DistanceUnits
        {
            NoUnit,
            Feet,
            Meter,
            Mile
        }

        /// <summary>
        /// Used to run the converter
        /// </summary>
        /// 
        public void Run()
        {
            OutputHeading();
            Choice();
            Conversions();
        }

        /// <summary>
        /// Used to accept input for feet and do data validation
        /// </summary>
        private void InputFeet()
        {
            while (check != true || feet < 0)
            {
                Console.Write("Enter The Number Of Feet > ");
                value = Console.ReadLine();

                check = double.TryParse(value, out feet);
                if (check == true)
                {
                    feet = Convert.ToDouble(value);
                }
                if (check != true || feet < 0)
                {
                    Console.WriteLine("Your Input is invalid");
                }

            }
        }

        /// <summary>
        /// Used to accept input for miles and do data validation
        /// </summary>
        private void InputMiles()
        {
            while (check != true || miles < 0)
            {
                Console.Write("Enter The Number Of Miles >");
                value = Console.ReadLine();

                check = double.TryParse(value, out miles);

                if (check == true)
                {
                    miles = Convert.ToDouble(value);
                }
                if (check != true || miles < 0)
                {
                    Console.WriteLine("Your Input is invalid");
                }
            }
        }

        /// <summary>
        /// Used to accept input for miles and do data validation
        /// </summary>
        private void InputMeters()
        {
            while (check != true || meters < 0)
            {
                Console.Write("Enter The Number Of Meters >");
                value = Console.ReadLine();
                check = double.TryParse(value, out meters);
                if (check == true) 
                { 
                meters = Convert.ToDouble(value);
                }
                if (check != true || meters < 0 )
                {
                    Console.WriteLine("Your Input is invalid");
                }
            }

        }

        /// <summary>
        /// Used to convert feet into miles
        /// </summary>
        private void ConvertFeetToMiles()
        {
            miles = feet / MILES_IN_FEET;
        }

        /// <summary>
        /// Used to convert feet into meters
        /// </summary>
        private void ConvertFeetToMeters()
        {
            meters = feet / FEET_IN_METERS;
        }

        /// <summary>
        /// Used to convert Miles to Feet
        /// </summary>
        private void ConvertMilesToFeet()
        {
            feet = miles * MILES_IN_FEET;
        }

        /// <summary>
        /// Used to convert miles into meters
        /// </summary>
        private void ConvertMilesToMeters()
        {
            meters = miles * MILES_IN_METERS;
        }

        /// <summary>
        /// Used to convert meters into miles
        /// </summary>
        private void ConvertMetersToMiles()
        {
            miles = meters / MILES_IN_METERS;
        }

        /// <summary>
        /// Used to convert meters into feet
        /// </summary>
        private void ConvertMetersToFeet()
        {
            feet = meters * FEET_IN_METERS;
        }

        /// <summary>
        /// Outputs a heading for the app
        /// </summary>
        public void OutputHeading()
        {
            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("            Distance Converter                    ");
            Console.WriteLine("               by Kyle Whynn                      ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }
        /// <summary>
        ///  Lets the user choose their units for conversion
        /// </summary>
        public void Choice() 
        {

            while (convertfrom < 1 || convertfrom > 3)

            {

                Console.WriteLine("Select distance unit you to convert from");
                Console.WriteLine("1. Feet");
                Console.WriteLine("2. Meters");
                Console.WriteLine("3. Miles");
                Console.WriteLine();
                Console.Write("> ");
                convertfrom = int.Parse(Console.ReadLine());

                if (convertfrom < 1 || convertfrom > 3) 
                {
                    Console.WriteLine();
                    Console.WriteLine("Your Input is invalid");
                    Console.WriteLine();

                }

            }

            Console.WriteLine();
            if (convertfrom == 1)
            {
                while (convertto < 2 || convertto > 3)
                {
                    Console.WriteLine("Select distance unit you to convert to");
                    Console.WriteLine("2. Meters");
                    Console.WriteLine("3. Miles");
                    Console.WriteLine();
                    Console.Write("> ");
                    convertto = int.Parse(Console.ReadLine());

                    if (convertto < 2 || convertto > 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your Input is invalid");
                        Console.WriteLine();
                    }
                }
            }
            else if (convertfrom == 2)
            {
                while (convertto < 1 || convertto > 3 || convertto == 2)
                {
                    Console.WriteLine("Select distance unit you to convert to");
                    Console.WriteLine("1. Feet");
                    Console.WriteLine("3. Miles");
                    Console.WriteLine();
                    Console.Write("> ");
                    convertto = int.Parse(Console.ReadLine());

                    if (convertto < 1 || convertto > 3 || convertto == 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your Input is invalid");
                        Console.WriteLine();
                    }
                }
            }
            
            else if (convertfrom == 3)
            {
                while (convertto < 1 || convertto > 2)
                {
                    Console.WriteLine("Select distance unit you to convert to");
                    Console.WriteLine("1. Feet");
                    Console.WriteLine("2. Meters");
                    Console.WriteLine();
                    Console.Write("> ");
                    convertto = int.Parse(Console.ReadLine());

                    if (convertto < 1 || convertto > 2)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Your Input is invalid");
                        Console.WriteLine();
                    }
                }
            }

             if (convertfrom < 1 || convertfrom > 3) 
                {
                    
                    Console.WriteLine("Your Input is invalid");

                } 
            
        }

        /// <summary>
        /// Converters the units from one to another
        /// </summary>
        public void Conversions() 
        {
            if (convertto == (int)DistanceUnits.Feet && convertfrom == (int)DistanceUnits.Mile)
            {
                Console.WriteLine();

                InputMiles();
                ConvertMilesToFeet();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Miles entered was " + miles);
                Console.WriteLine("Miles converted to Feet is " + feet);
            }
            else if (convertfrom == (int)DistanceUnits.Feet && convertto == (int)DistanceUnits.Mile)
            {
                Console.WriteLine();
                InputFeet();
                ConvertFeetToMiles();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Feet entered was " + feet);
                Console.WriteLine("Feet converted to Miles is " + miles);
            }
            else if (convertfrom == (int)DistanceUnits.Feet && convertto == (int)DistanceUnits.Meter)
            {
                Console.WriteLine();
                InputFeet();
                ConvertFeetToMeters();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Feet entered was " + feet);
                Console.WriteLine("Feet converted to Meter is " + meters);
            }
            else if (convertto == (int)DistanceUnits.Meter && convertfrom == (int)DistanceUnits.Mile)
            {
                Console.WriteLine();
                InputMiles();
                ConvertMilesToMeters();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Miles entered was " + miles);
                Console.WriteLine("Feet converted to Miles is " + meters);
            }
            else if (convertfrom == (int)DistanceUnits.Meter && convertto == (int)DistanceUnits.Mile)
            {
                Console.WriteLine();
                InputMeters();
                ConvertMetersToMiles();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Meters entered was " + meters);
                Console.WriteLine("Meters converted to Miles is " + miles);
            }
            else if (convertfrom == (int)DistanceUnits.Meter && convertto == (int)DistanceUnits.Feet)
            {
                Console.WriteLine();
                InputMeters();
                ConvertMetersToFeet();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Meters entered was " + meters);
                Console.WriteLine("Meters converted to Feet is " + feet);
            } 
            while (convertto < 0 || convertto > 3 || convertfrom < 0 || convertfrom > 3)
            {
                Console.WriteLine("Your Input is invalid");
                Console.WriteLine();
                Choice();  
            }

        }

    }

}
