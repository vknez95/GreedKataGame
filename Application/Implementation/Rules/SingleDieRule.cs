using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation.Rules
{
    public class SingleDieRule : IRule
    {
        private readonly DieValue dieValue;
        private readonly int score;

        public SingleDieRule(DieValue dieValue, int score)
        {
            this.dieValue = dieValue;
            this.score = score;
        }

        public string Description => $"A single {dieValue.ToString().ToLower()} ({score})";

        public ScoreResult Eval(int[] dice)
        {
            int[] diceUsed = dice.Where(d => d == dieValue.Value).ToArray();
            int diceScore = diceUsed.Count() * score;
            
            return new ScoreResult(diceUsed, diceScore, this, diceUsed.Count());
        }
    }
}
