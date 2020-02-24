// --------------------------------------------------------------------------------------------------------------------
// <copyright Project=MoodAnalyzerProblem" Company="Bridgelabz">
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
        /// test case 4.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
                HappyOrSadMood mood = new HappyOrSadMood("I am in sad mood");
                 bool actual = mood.Equals(MoodFactory.CreatehappyOrSadMood("HappyOrSadMood"));
                   bool expected = true; 
                Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.2
        /// Throw exception 
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood(null);
            string actual = mood.AnalyseMood();
            string expected = "null exception caught";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest()
        {
            HappyOrSadMood mood = new HappyOrSadMood("hjbdvysezbgv");
            string actual = mood.AnalyseMood();
            string expected = null;
            Assert.AreEqual(actual, expected);
        }
    }
}