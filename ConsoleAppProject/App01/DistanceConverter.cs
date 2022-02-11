using System;
namespace ConsoleAppProject.App01
{
    /// <summary>
    /// This app converts Miles to Feet
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
        private double miles;
        private double feet;
        private double meters;
        private string value;
        private bool check;
        /// <summary>
        /// Used to run both the converters
        /// </summary>
        public void Run()
        {
            DistanceConverter converter = new DistanceConverter();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    Which Converter Would you Like to Run?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    a = Feet to Miles Converter");
            Console.WriteLine("    b = Miles To Meter Converter");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("    >");

            string value = Console.ReadLine();
            value.ToLower();

            switch (value)
            {

                case "a":

                    converter.ConvertFeetToMiles();
                    break;

                case "b":
                    converter.ConvertMilesToMeters();
                    break;
            }

        }

        /// <summary>
        /// Used to accept input for feet and do data validation
        /// </summary>
        private void InputFeet()
        {
            while (check != true)
            {
                Console.Write("Enter The Number Of Feet > ");
                value = Console.ReadLine();

                check = double.TryParse(value, out feet);
                if (check != true)
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
            while (check != true)
            {
                Console.Write("Enter The Number Of Miles >");
                value = Console.ReadLine();

                check = double.TryParse(value, out miles);
                if (check != true)
                {
                    Console.WriteLine("Your Input is invalid");
                }
            }

        }

        /// <summary>
        /// Used to convert feet into miles
        /// </summary>
        private void CalculateMiles()
        {
            miles = feet * MILES_IN_FEET;
        }

        /// <summary>
        /// Used to convert miles into meters
        /// </summary>
        private void CalculateMeters()
        {
            meters = miles * MILES_IN_METERS;
        }

        /// <summary>
        /// Used to ouput converted miles value
        /// </summary>
        private void OutputMiles()
        {
            Console.WriteLine("Feet converted in Miles is " + miles + "m");
        }

        /// <summary>
        /// Used to ouput converted meters value
        /// </summary>
        private void OutputMeters()
        {
            Console.WriteLine("Miles converted in Meters is " + meters + "m");
        }

        /// <summary>
        /// Used to do the conversion procress for feet to miles
        /// </summary>
        public void ConvertFeetToMiles()
        {
            OutputHeading();
            InputFeet();
            CalculateMiles();
            OutputMiles();
        }

        /// <summary>
        /// Used to do the conversion procress for miles to meters
        /// </summary>
        public void ConvertMilesToMeters()
        {
            OutputHeading();
            InputMiles();
            CalculateMeters();
            OutputMeters();
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

    }

}
