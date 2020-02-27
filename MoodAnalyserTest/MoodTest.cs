// --------------------------------------------------------------------------------------------------------------------
// <copyright Project=MoodAnalyzerProblem" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// --------------------------------------------------------------------------------------------------------------------
using MoodAnalyzerProblem;
using NUnit.Framework;
using System;
using System.Reflection;

namespace MoodAnalyserTest
{
    [TestFixture]
    public class Tests
    {
        /// <summary>
        /// test case 7.1
        ///Using Reflection When Proper Should Return HAPPY Mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodHappyTest()
        {
            string actual = MoodFactory.ChangeMoodDynamically("I am in happy mood");
            string expected = "Happy";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 7.2
        /// When  set the improper value and the Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest()
        {
            string actual = MoodFactory.ChangeMoodDynamically("rtdkmduygkly");
            string expected = "No_Such_Field_Error";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 7.3
        /// Setting Null Message with Reflector Should Throw Exception
        /// </summary>
       [TestCase]
        public void AnalyserMoodNullExceptionTest()
        {
            string actual = MoodFactory.ChangeMoodDynamically(null);
            string expected = "Null";
            Assert.AreEqual(actual, expected);
        }
    }
}