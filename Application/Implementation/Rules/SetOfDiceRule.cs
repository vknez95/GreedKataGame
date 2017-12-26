using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation.Rules
{
    public class SetOfDiceRule : IRule
    {
        private readonly RuleSetSize setSize;
        private readonly DieValue dieValue;
        private readonly int score;

        public SetOfDiceRule(RuleSetSize setSize, DieValue dieValue, int score)
        {
            this.setSize = setSize;
            this.dieValue = dieValue;
            this.score = score;
        }

        public string Description {
            get {
                var output = $"{setSize}-of-a-kind [";

                int i = 0;
                while(i < setSize.Value)
                {
                    i++;
                    output += $"{dieValue.Value},";
                }

                output = output.Substring(0, output.Length - 1);
                return $"{output}] ({score})";
            }
        }

        public ScoreResult Eval(int[] dice)
        {
            int dieCount = dice.Count(d => d == dieValue.Value);

            if (dieCount >= setSize.Value)
            {
                List<int> diceUsed = new List<int>();
                while (diceUsed.Count < setSize.Value)
                {
                    diceUsed.Add(dieValue.Value);
                }

                int numberOfTimesRuleUsed = dieCount / setSize.Value;
                return new ScoreResult(diceUsed.ToArray(), score, this, numberOfTimesRuleUsed);
            }
            else
            {
                return new ScoreResult(null, 0, null, 0);
            }
        }
    }
}
