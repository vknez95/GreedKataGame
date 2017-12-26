using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation.Rules
{
    public class ThreePairsRule : IRule
    {
        private List<int> pairValues = new List<int>();

        public string Description
        {
            get
            {
                if (pairValues.Count == 3)
                {
                    return $"Three pairs [{pairValues[0]},{pairValues[0]},{pairValues[1]},{pairValues[1]},{pairValues[2]},{pairValues[2]}]";
                }
                else
                {
                    return "";
                }
            }
        }

        public ScoreResult Eval(int[] dice)
        {
            int pairCount = 0;
            var diceUsed = new List<int>();
            for (int i = 1; i < 7; i++)
            {
                var count = dice.Count(d => d == i);
                if (count % 2 == 0)
                {
                    for (int j = 0; j < count; j++)
                    {
                        diceUsed.Add(i);
                        if (j % 2 == 0)
                        {
                            pairCount++;
                            pairValues.Add(i);
                        }
                    }
                }
            }
            if (pairCount == 3)
            {
                return new ScoreResult(diceUsed.ToArray(), 800, this, 1);
            }
            return new ScoreResult(null, 0, null, 0);
        }
    }
}
