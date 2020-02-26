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
        /// test case 4.1
        /// check Object are equal are not
        /// </summary>
        [TestCase]
        public void AnalyserMoodObjectTest()
        {
            Type type = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
            object classObject = constructorInfo.Invoke(new object[] { });
            bool actual = classObject.Equals(type);
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
            Type type = MoodFactory.CreateHappyOrSadMoodUsingReflection("MoodAnalyzerProblem.HappyOrSadMood");
            ConstructorInfo constructorInfo = type.GetConstructor(Type.EmptyTypes);
            object classObject = constructorInfo.Invoke(new object[] { });
            Type type1 = MoodFactory.CreateHappyOrSadMoodUsingReflection("wrong class name");
            bool actual = classObject.Equals(type1);
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
            HappyOrSadMood mood = new HappyOrSadMood("mxbvyusgvjcbka");
            string actual = mood.AnalyseMood();
            string expected = null;
            Assert.AreEqual(actual, expected);
        }
    }
}