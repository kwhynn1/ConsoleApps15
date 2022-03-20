using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{

    /// <summary>
    /// This application will allow a tutor to enter a single mark of each of a list of 
    /// students and it will convert that mark into a grade. The application will 
    /// then be able to calculate simple statistics 
    /// and also calculate and display a student grade profile.
    /// </summary>

    /// <author>
    /// Kyle Whynn
    /// </author>

    public class StudentGrades
    {
        /// <summary>
        /// Thesse are the varibles 
        /// used in the classess
        /// </summary>
        public const int MIN_F = 0;
        public const int MIN_D = 40;
        public const int MIN_C = 50;
        public const int MIN_B = 60;
        public const int MIN_A = 70;
        public int Mark;
        public double F = 0;
        public double D = 0;
        public double C = 0;
        public double B = 0;
        public double A = 0;

        /// <summary>
        /// Arrays declared for use
        /// </summary>
        public string[] Students;
        public int[] Marks;
        
        /// <summary>
        /// enun class with grades 
        /// for program
        /// </summary>
        public enum Grades
        {
            X,
            F,
            D,
            C,
            B,
            A
        }

        /// <summary>
        /// Used to run the program
        /// </summary>
        public void Run()
        {
            Students = new string [] { "Kwame", "Kofi", "Oni", "Adassa", "Adisa", "Kaapo", "Kael", "Kaden", "Aasir", "Jahseh"};
            Marks = new int[Students.Length];
            ConsoleHelper.OutputHeading("App03 Student Marks");
          
            Menu("Select Your Choice From The Menu");
        }

        /// <summary>
        /// Use to input the student's marks
        /// </summary>
        private void InputMarks() 
        {
            int counter = 0;

            foreach (string name in Students)
            {   
                Mark = (int)ConsoleHelper.InputNumber($"Enter a Mark For {Students[counter]} >", 0, 100);
                Marks[counter] = Mark;
                counter = counter + 1;
            }
        }

        /// <summary>
        ///  Outputs the student's mark, grade and name
        /// </summary>
        private void OutputStudents() 
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($" Name:{Students[i]}  mark = {Marks[i]}  grade = {grade}");
            }
        }

        /// <summary>
        /// Converts the marks into grades
        /// </summary>
        public Grades ConvertToGrades(int mark)
        {
            if (mark >= 0 && mark < MIN_D)
            {
                return Grades.F;
            }
            else if (mark >= MIN_D & mark < MIN_C)
            {
                return Grades.D;
            }
            else if (mark >= MIN_C & mark < MIN_B)
            {
                return Grades.C;
            }
            else if (mark >= MIN_B & mark < MIN_A)
            {
                return Grades.B;
            }
            else if (mark >= MIN_A)
            {
                return Grades.A;
            }
            else return Grades.X;
        }

        /// <summary>
        ///  Find the minimum mark in the 
        ///  marks array
        /// </summary>
        public int MinimumMark ()
        {
            int minmark = Marks[0];

            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] < minmark) 
                { 
                    minmark = Marks[i]; 
                }
            }
            return minmark;
        }

        /// <summary>
        ///  Find the maximum mark in the 
        ///  marks array
        /// </summary>
        public int MaximumMark()
        {
            int maxmark = Marks[0];

            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] > maxmark)
                {
                    maxmark = Marks[i];
                }
            }
            return maxmark;
        }

        /// <summary>
        /// UUSe to calculate the mean maek from
        /// marks array
        /// </summary>
        public double MeanMark() 
        {
            int mark = 0;

            for (int i = 0; i < Students.Length; i++)
            {
                 mark = Marks[i] + mark;
            }
            
            double meanMark = (double)mark / Students.Length;

            return meanMark;
        }

        /// <summary>
        /// Allows use to select from
        /// a menu
        /// </summary>
        private void Menu(string prompt)
        {
            string[] choices =
                {
                    $" Input Marks",
                    $" Output Students Info",
                    $" Output Stats",
                    $" Output Grade Profile",
                    $" Exit/Close"
                };

            Console.WriteLine();
            Console.WriteLine(prompt);
            Console.WriteLine();
            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                Console.WriteLine();
                InputMarks();
                Menu("Select Your Choice From The Menu");
            }
            else if (choice == 2)
            {
                Console.WriteLine();
                OutputStudents();
                Menu("Select Your Choice From The Menu");

            }
            else if (choice == 3)
            {
                Console.WriteLine();
                Console.WriteLine($" The Minimum Mark is {MinimumMark()} \n The Maximum Mark is {MaximumMark()} \n The Mean Mark is {MeanMark()}");
                Menu("Select Your Choice From The Menu");
            } 
            else if (choice == 4)
            {
                Console.WriteLine();
                GradeProfiles();
                CalculateGradeProfiles();
                OutputGradeProfiles();
                Menu("Select Your Choice From The Menu");
            }
            else if (choice == 5)
            {
                Environment.Exit(0);
            }

        }

        /// <summary>
        /// Counts the amount of 
        /// grades
        /// </summary>
        private void GradeProfiles ()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                
                if (grade == Grades.X || grade == Grades.F) 
                {
                    F = F + 1;
                }
                else if (grade == Grades.D)
                {
                    D = D + 1;
                }
                else if (grade == Grades.C)
                {
                    C = C + 1;
                }
                else if (grade == Grades.B)
                {
                    B = B + 1;
                }
                else if (grade == Grades.A)
                {
                    A = A + 1;
                }
            }


        }

        /// <summary>
        /// Calculate the GradeProfiles
        /// </summary>
        private void CalculateGradeProfiles()
        {
            F = F / Students.Length;
            D = D / Students.Length;
            C = C / Students.Length;
            B = B / Students.Length;
            A = A / Students.Length;
        }

        /// <summary>
        /// Outputs the Grade Profile
        /// </summary>
        private void OutputGradeProfiles ()
        { 
            Console.WriteLine("The Amount Of Students that Got A Grade:\nF: " + F.ToString("P")  +  "\n" + "D: " + D.ToString("P") + "\n" + "C: " +  C.ToString("P") +  "\n" + "B: " + B.ToString("P") +  "\n" + "A: " + A.ToString("P"));
        }

    }
}
