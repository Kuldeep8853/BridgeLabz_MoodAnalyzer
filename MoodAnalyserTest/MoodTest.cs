// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
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
            Assert.AreEqual(actualResult, expected);
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

        /// <summary>
        /// test case 2.1
        /// test for any mood
        /// </summary>
        //[TestCase]
        //public void AnalyserMoodNULLTest()
        //{
        //    HappyOrSadMood mood = new HappyOrSadMood(null);
        //    string expected = "Happy";
        //    string actualResult = mood.AnalyseMood();
        //    Assert.AreEqual(actualResult, expected);
        //}

        /// <summary>
        /// test case 3.1
        /// Given Empty Mood
        /// Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [TestCase]
        public void MoodAnalysisNullExceptionTest()
        {
                HappyOrSadMood mood = new HappyOrSadMood(null);
                string expected = "NULL";
                string actualResult = mood.AnalyseMood();
                Assert.AreEqual(actualResult, expected);
        }
        public void MoodAnalysisEmptyExceptionTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("");
            string expected = "EMPTY";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult, expected);
        }
    }
}