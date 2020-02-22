// --------------------------------------------------------------------------------------------------------------------
// <copyright file=HappyOrSadMood.cs" Company="Bridgelabz">
//   Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Kuldeep Kasaudhan"/>
// ----------------------------------------------------------------------------------------------------------------------
namespace MoodAnalyzerProblem
{
    /// <summary>
    /// Check mood sad or happy
    /// </summary>
    public class HappyOrSadMood{
       public string AnalyseMood(string message)
        {
            if(message.Equals("I am in sad mood"))
            {
                return "Sad";
            }
            return "Happy";
        }

    }
}
