// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ---------------------------------------------------------------------------------------------------------------------
using MoodAnalyzerProblem;
using NUnit.Framework;

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
            HappyOrSadMood mood = new HappyOrSadMood("I am in sad mood");
            string expected = "Sad";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult,expected);
        }

        /// <summary>
        /// test case 1.2
        /// test for any mood
        /// </summary>
        [TestCase]
        public void AnalyseHappyMoodTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("I am in any mood");
            string expected = "Happy";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult, expected);
        }

        /// <summary>
        /// test case 2.1
        /// test for any mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodNULLTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("I am in any mood");
            string expected = "Happy";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult, expected);
        }
    }
}