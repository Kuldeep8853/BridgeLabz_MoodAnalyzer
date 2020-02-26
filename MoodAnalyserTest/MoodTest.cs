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
        /// test case 6.1
        ///Using Reflection When Proper Should Return HAPPY Mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodHappyTest()
        {
            HappyOrSadMood result = MoodFactory.MoodAnalyserReflector("MoodAnalyzerProblem.HappyOrSadMood");
            string actual = result.AnalyseMood().ToString() + " Mood";
            string expected = "Happy Mood";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 6.2
        /// When Improper Method Should Throw MoodAnalysisException
        /// </summary>
        //[TestCase]
        //public void AnalyserMoodExceptionTest()
        //{
        //    string actual = MoodFactory.MoodAnalyserReflector("zdgbdxjmcgbmujh");
        //    Console.WriteLine(actual);
        //    string expected = "Happy";
        //    Assert.AreEqual(actual, expected);
        //}
    }
}