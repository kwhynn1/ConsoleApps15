using System;
using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.App04;
namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start App01 to App05 for CO453 CW1
    /// 
    /// This Project has been modified by:
    /// Kyle WHynn 07/02/2022
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;

            string ans;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Applications Programming 2021-2022! ");
            Console.WriteLine("        by Kyle Whynn         ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();

            Console.WriteLine("    Which App Would you Like to Run?");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("    a = Distance Converter");
            Console.WriteLine();
            Console.WriteLine("    b = BMI Converter");
            Console.WriteLine();
            Console.WriteLine("    c = Grade Calculator");
            Console.WriteLine();
            Console.WriteLine("    d = Social Network");
            Console.WriteLine();
            Console.Write("    >");
            ans = Console.ReadLine();
            ans.ToLower();

            
                switch (ans)
                {

                    case "a":

                        DistanceConverter converter = new DistanceConverter();
                        converter.Run();
                        break;

                    case "b":

                        BMI BMIconverter = new BMI();
                        BMIconverter.Run();
                        break;
                case "c":

                   StudentGrades app03 = new StudentGrades();
                    app03.Run();
                    break;
                case "d":

                    NetworkApp app04 = new NetworkApp();
                    app04.Run();
                    break;


                default:

                    Console.WriteLine("    Which App Would you Like to Run?");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("    a = Distance Converter");
                    Console.WriteLine();
                    Console.WriteLine("    b = BMI Converter");
                    Console.WriteLine();
                    Console.WriteLine("    c = Grade Calculator");
                    Console.WriteLine();
                    Console.WriteLine("    d = Social Network");
                    Console.WriteLine();
                    Console.Write("    >");
                    ans = Console.ReadLine();
                    ans.ToLower();
                    break;
                }
            

        }


    }
   
}
