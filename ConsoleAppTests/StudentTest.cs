using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleAppTests
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void ConvertToGradeF()
        {
            StudentGrades app03 = new StudentGrades();

            app03.Mark = 10;

            StudentGrades.Grades grade =  app03.ConvertToGrades(app03.Mark);

            StudentGrades.Grades expectedGrade = StudentGrades.Grades.F ;

            Assert.AreEqual(expectedGrade, app03.ConvertToGrades(app03.Mark));
        }

        [TestMethod]
        public void ConvertToGradeA()
        {
            StudentGrades app03 = new StudentGrades();

            app03.Mark = 71;

            StudentGrades.Grades grade = app03.ConvertToGrades(app03.Mark);

            StudentGrades.Grades expectedGrade = StudentGrades.Grades.A;

            Assert.AreEqual(expectedGrade, app03.ConvertToGrades(app03.Mark));
        }

        [TestMethod]
        public void ConvertToGradeD()
        {
            StudentGrades app03 = new StudentGrades();

            app03.Mark = 41;

            StudentGrades.Grades grade = app03.ConvertToGrades(app03.Mark);

            StudentGrades.Grades expectedGrade = StudentGrades.Grades.D;

            Assert.AreEqual(expectedGrade, app03.ConvertToGrades(app03.Mark));
        }

        [TestMethod]
        public void ConvertToGradeC()
        {
            StudentGrades app03 = new StudentGrades();

            app03.Mark = 51;

            StudentGrades.Grades grade = app03.ConvertToGrades(app03.Mark);

            StudentGrades.Grades expectedGrade = StudentGrades.Grades.C;

            Assert.AreEqual(expectedGrade, app03.ConvertToGrades(app03.Mark));
        }

        [TestMethod]
        public void ConvertToGradeB()
        {
            StudentGrades app03 = new StudentGrades();

            app03.Mark = 61;

            StudentGrades.Grades grade = app03.ConvertToGrades(app03.Mark);

            StudentGrades.Grades expectedGrade = StudentGrades.Grades.B;

            Assert.AreEqual(expectedGrade, app03.ConvertToGrades(app03.Mark));
        }

        [TestMethod]
        public void MinGradeTest()
        {
            StudentGrades app03 = new StudentGrades();
            app03.Marks= new int[] {1, 54, 52, 70, 80, 1, 0, 52, 70, 80};

            int minMark = app03.MinimumMark();

         
            int expectedMark = 0;

            Assert.AreEqual(expectedMark, minMark);
        }

        [TestMethod]
        public void MaxGradeTest()
        {
            StudentGrades app03 = new StudentGrades();
            app03.Marks = new int[] { 1, 54, 52, 70, 80, 1, 0, 52, 70, 90 };

            int maxMark = app03.MaximumMark();

            int expectedMark = 90;

            Assert.AreEqual(expectedMark, maxMark);
        }

        [TestMethod]
        public void MeanGradeTest()
        {
            StudentGrades app03 = new StudentGrades();
            app03.Marks = new int[] { 1, 54, 52, 70, 80, 1, 0, 52, 70, 90 };
            app03.Students = new string[] { "Kwame", "Kofi", "Oni", "Adassa", "Adisa", "Kaapo", "Kael", "Kaden", "Aasir", "Jahseh" };
            double meanMark = app03.MeanMark();

            int expectedMean = 47;
            
            Assert.AreEqual(expectedMean, meanMark);
        }




    }
}

