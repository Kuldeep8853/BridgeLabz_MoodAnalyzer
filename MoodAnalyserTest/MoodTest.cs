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
    public class MoodTest
    {
        /// <summary>
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
        }

        /// <summary>
        /// Test case 3.1
        /// Given Empty Mood
        /// Should Throw MoodAnalysisException indicating null Mood
        /// </summary>
        [TestCase]
        public void MoodAnalysisNullExceptionTest()
        {
            MoodAnalyser mood = new MoodAnalyser(null);
            string expected = "NULL";
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 3.2
        /// Given Empty Mood
        /// Should Throw MoodAnalysisException indicating null Mood
        /// </summary>
        [TestCase]
        public void MoodAnalysisEmptyExceptionTest()
        {
            MoodAnalyser mood = new MoodAnalyser("");
            string expected = "EMPTY";
            string actual = mood.AnalyseMood();
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test case 4.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
            MoodAnalyser MoodReflectionObject = (MoodAnalyser)MoodAnalyserReflector.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser();
            bool actual = mood.Equals(MoodReflectionObject);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 4.2
        /// Throw exception 
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest()
        {
            object MoodReflectionObject = MoodAnalyserReflector.CreateMoodAnalyserObject("Wrong class name");
            string actual = MoodReflectionObject.ToString();
            string expected = "No_Such_Class_Error";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test case 4.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest()
        {
            string[] ctor = new string[2];
            ctor[0] = "HAPPY";
            object MoodReflectionObject = MoodAnalyserReflector.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", ctor);
            string actual = MoodReflectionObject.ToString();
            string expected = "No_Such_Method_Error";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 5.1
        /// check Object are equal
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest1()
        {
            MoodAnalyser MoodReflectionObject = (MoodAnalyser)MoodAnalyserReflector.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser");
            MoodAnalyser mood = new MoodAnalyser("I am in Happy mood");
            bool actual = mood.Equals(MoodReflectionObject);
            bool expected = true;
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 5.2
        /// Throw exception 
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest1()
        {
            object MoodReflectionObject = MoodAnalyserReflector.CreateMoodAnalyserObject("Wrong class name");
            string actual = MoodReflectionObject.ToString();
            string expected = "No_Such_Class_Error";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// Test case 5.3
        /// Constructor Not Proper Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodContructorTest1()
        {
            string[] ctor = new string[2];
            ctor[0] = "HAPPY";
            object MoodReflectionObject = MoodAnalyserReflector.CreateMoodAnalyserObject("MoodAnalyzerProblem.MoodAnalyser", ctor);
            string actual = MoodReflectionObject.ToString();
            string expected = "No_Such_Method_Error";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// test case 6.1
        ///Using Reflection When Proper Should Return HAPPY Mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodHappyTest2()
        {
            string actual = MoodAnalyserReflector.MoodAnalyserReflector1("AnalyseMood");
            string expected = "Happy";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// test case 6.2
        /// When Improper Method Should Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionTest2()
        {
            string actual = MoodAnalyserReflector.MoodAnalyserReflector1("Wrong_Method_Name");
            string expected = "Happy";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// test case 7.1
        ///Using Reflector When Proper Should Return HAPPY Mood
        /// </summary>
        [TestCase]
        public void AnalyserMoodWithRefactor()
        {
            string actual = MoodAnalyserReflector.ChangeMoodDynamically("I am in happy mood");
            string expected = "Happy";
            Assert.AreEqual(actual, expected);
        }
        /// <summary>
        /// test case 7.2
        /// When  set the improper value and the Throw MoodAnalysisException
        /// </summary>
        [TestCase]
        public void AnalyserMoodExceptionWithRefactot()
        {
            string actual = MoodAnalyserReflector.ChangeMoodDynamically("Improper_Message");
            string expected = "No_Such_Field_Error";
            Assert.AreEqual(actual, expected);
        }

        /// <summary>
        /// Test case 7.3
        /// Setting Null Message with Reflector Should Throw Exception
        /// </summary>
       [TestCase]
        public void AnalyserMoodNullExceptionWithRefacto()
        {
            string actual = MoodAnalyserReflector.ChangeMoodDynamically(null);
            string expected = "NULL";
            Assert.AreEqual(actual, expected);
        }
    }
}