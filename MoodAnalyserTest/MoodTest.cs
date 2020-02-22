using MoodAnalyzerProblem;
using NUnit.Framework;
using System;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// test case 1.1 
        /// test for sad mood
        /// </summary>
        [TestCase]
        public void AnalyseSadMoodTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood();
            string expected = "Sad";
            string actualResult = mood.AnalyseMood("I am in sad mood");
            Assert.AreEqual(actualResult,expected);
        }

        /// <summary>
        /// test case 1.2
        /// test for any mood
        /// </summary>
        [TestCase]
        public void AnalyseHappyMoodTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood();
            string expected = "Happy";
            string actualResult = mood.AnalyseMood("I am in any mood");
            Assert.AreEqual(actualResult, expected);
        }
    }
}