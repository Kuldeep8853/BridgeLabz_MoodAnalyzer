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
        /*/// <summary>
        /// Test case 1.1 
        /// Test for sad mood
        /// </summary>
        [TestCase]
        public void AnalyseSadMoodTest()
        {
            MoodAnalyser mood = new MoodAnalyser("I am in sad mood");
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
            MoodAnalyser mood = new MoodAnalyser("I am in happy mood");
            string expected = "Happy";
            string actualResult = mood.AnalyseMood();
            Assert.AreEqual(actualResult, expected);
        }*/

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
        /*
                /// <summary>
                /// test case 3.1
                /// Given Empty Mood
                /// Should Throw MoodAnalysisException indicating null Mood
                /// </summary>
                [TestCase]
                public void MoodAnalysisNullExceptionTest()
                {
                    MoodAnalyser mood = new MoodAnalyser(null);
                    string expected = "NULL";
                    string actualResult = mood.AnalyseMood();
                    Assert.AreEqual(actualResult, expected);
                }
        *//*
                /// <summary>
                /// test case 3.2
                /// Given Empty Mood
                /// Should Throw MoodAnalysisException indicating null Mood
                /// </summary>
                [TestCase]
                public void MoodAnalysisEmptyExceptionTest()
                {
                    MoodAnalyser mood = new MoodAnalyser("");
                    string expected = "EMPTY";
                    string actualResult = mood.AnalyseMood();
                    Assert.AreEqual(actualResult, expected);
                }*/
        /// <summary>
        /// test case 4.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {

            MoodAnalyser MoodReflectionObject = MoodAnalyserFactory.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(MoodReflectionObject);
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
            MoodAnalyser MoodReflectionObject = MoodAnalyserFactory.CreateMoodAnalyserObject("Wrong class name");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(MoodReflectionObject);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// test case 4.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest()
        {
            MoodAnalyser MoodReflectionObject = MoodAnalyserFactory.CreateMoodAnalyserObject2("MoodAnalyzerProblem.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(MoodReflectionObject);
            bool expected = false;
            Assert.AreEqual(actual, expected);
        }
    }
}