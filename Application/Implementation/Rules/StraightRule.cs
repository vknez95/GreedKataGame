using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation.Rules
{
    public class StraightRule : IRule
    {
        private readonly int score = 1200;

        public string Description => $"Straight [1,2,3,4,5,6] ({score})";

        public ScoreResult Eval(int[] dice)
        {
            for (int i = 1; i < 7; i++)
            {
                if (!dice.Contains(i))
                {
                    return new ScoreResult(null, 0, null, 0);
                }
            }
            var diceUsed = new int[] { 1, 2, 3, 4, 5, 6 };
            return new ScoreResult(diceUsed, score, this, 1);
        }
    }
}
