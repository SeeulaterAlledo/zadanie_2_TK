using Microsoft.VisualStudio.TestTools.UnitTesting;
using zadanie_2_TK; 

namespace ExamScoreCalculator.Tests
{
    [TestClass]
    public class GradeCalculatorTests
    {
        [TestMethod]
        public void CalculateGrade_56to80_ReturnsExcellent()
        {
            
            int[] excellentScores = { 56, 70, 80 };

            foreach (var score in excellentScores)
            {
               
                string result = Program.CalculateGrade(score);

                
                Assert.AreEqual("5 (отлично)", result,
                    $"Ожидалась оценка '5' для баллов {score}");
            }
        }

        [TestMethod]
        public void CalculateGrade_32to55_ReturnsGood()
        {
            
            int[] goodScores = { 32, 45, 55 };

            foreach (var score in goodScores)
            {
                
                string result = Program.CalculateGrade(score);

                
                Assert.AreEqual("4 (хорошо)", result,
                    $"Ожидалась оценка '4' для баллов {score}");
            }
        }

        [TestMethod]
        public void CalculateGrade_16to31_ReturnsSatisfactory()
        {
            
            int[] satisfactoryScores = { 16, 25, 31 };

            foreach (var score in satisfactoryScores)
            {
                
                string result = Program.CalculateGrade(score);

                
                Assert.AreEqual("3 (удовлетворительно)", result,
                    $"Ожидалась оценка '3' для баллов {score}");
            }
        }

        [TestMethod]
        public void CalculateGrade_0to15_ReturnsFail()
        {
            
            int[] failScores = { 0, 10, 15 };

            foreach (var score in failScores)
            {
                
                string result = Program.CalculateGrade(score);

                
                Assert.AreEqual("2 (неудовлетворительно)", result,
                    $"Ожидалась оценка '2' для баллов {score}");
            }
        }

        [TestMethod]
        public void CalculateGrade_NegativeScore_ReturnsUndefined()
        {
            
            string result = Program.CalculateGrade(-5);

            
            StringAssert.Contains(result, "неопределено");
        }

        [TestMethod]
        public void CalculateGrade_ScoreAboveMax_ReturnsUndefined()
        {
            
            string result = Program.CalculateGrade(81);

            
            StringAssert.Contains(result, "неопределено");
        }
    }
}