using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App03
{
    public class StudentGrades
    {
        public const int MIN_F = 0;
        public const int MIN_D = 40;
        public const int MIN_C = 50;
        public const int MIN_B = 60;
        public const int MIN_A = 70;
        public int F = 0;
        public int D = 0;
        public int C = 0;
        public int B = 0;
        public int A = 0;


        public string[] Students;
        public int[] Marks;
        public int Mark;

        public enum Grades
        {
            X,
            F,
            D,
            C,
            B,
            A
        }

        public void Run()
        {
            Students = new string [] { "Peter", "Kofi", "Oni" };
            Marks = new int[Students.Length];
            ConsoleHelper.OutputHeading("App03 Student Marks");
          
            Menu("Select Your Choice From The Menu");
        }

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

        private void OutputStudents() 
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                int mark = Marks[i];
                Grades grade = ConvertToGrades(mark);
                Console.WriteLine($" Name:{Students[i]}  mark = {Marks[i]}  grade = {grade}");
            }
        }

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

        private int MinimumMark ()
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

        private int MaximumMark()
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

        private int MeanMark() 
        {
            int mark = 0;

            for (int i = 0; i < Marks.Length; i++)
            {
                 mark = Marks[i] + mark;
            }
            int meanMark = mark / Marks.Length;

            return meanMark;
        }

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
                OutputGradeProfiles();
                Menu("Select Your Choice From The Menu");
            }
            else if (choice == 5)
            {
                Environment.Exit(0);
            }

        }

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

        private void OutputGradeProfiles ()
        { 
        
            Console.WriteLine($"The Amount Of Students that Got A Grade: \n F: {F} \n D: {D} \n C: {C} \n B: {B} \n A: {A} ");

        }
    }
}
