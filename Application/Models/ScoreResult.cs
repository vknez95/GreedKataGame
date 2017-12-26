using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Implementation;

namespace GreedKataGame.Application.Models
{
    public class ScoreResult
    {
        public readonly int[] DiceUsed;
        public readonly int Score;
        public readonly IRule RuleUsed;
        public readonly int NumberOfTimesRuleUsed;

        public ScoreResult(int[] diceUsed, int score, IRule ruleUsed, int numberOfTimesRuleUsed)
        {
            DiceUsed = diceUsed;
            Score = score;
            RuleUsed = ruleUsed;
            NumberOfTimesRuleUsed = numberOfTimesRuleUsed;
        }

        public string Description
        {
            get
            {
                if (NumberOfTimesRuleUsed > 1)
                {
                    return $"{RuleUsed.Description} x{NumberOfTimesRuleUsed}";
                }
                else
                {
                    return RuleUsed.Description;
                }
            }
        }
    }
}
