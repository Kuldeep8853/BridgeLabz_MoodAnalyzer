// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using MoodAnalyzerProblem;
using NUnit.Framework;
using System;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// test case 3.1
        /// Given Empty Mood
        /// Should Throw MoodAnalysisException indicating Empty Mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodNULLTest()
        {
                HappyOrSadMood mood = new HappyOrSadMood(null);
                string expected = "null exception caught";
                string actualResult = mood.AnalyseMood();
                Assert.AreEqual(actualResult, expected);
        }
    }
}