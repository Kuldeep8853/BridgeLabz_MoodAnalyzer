using MoodAnalyzerProblem;
using NUnit.Framework;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// Test case 1.1 
        /// Test for sad mood
        /// </summary>
        [TestCase]
        public void AnalyseSadMoodTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("I am in sad mood");
            string expected = "Sad";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult,expected);
        }

        /// <summary>
        /// Test case 1.2
        /// Test for any mood
        /// </summary>
        [TestCase]
        public void AnalyseHappyMoodTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("I am in happy mood");
            string expected = "Happy";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult, expected);
        }
    }
}