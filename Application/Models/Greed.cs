using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Implementation;
using GreedKataGame.Application.Implementation.Rules;
using GreedKataGame.Utility;

namespace GreedKataGame.Application.Models
{
    public class Greed
    {
        private readonly RuleSet _ruleSet = new RuleSet();
        private List<ScoreResult> rulesUsed = new List<ScoreResult>();

        public Greed()
            : this(true)
        {
        }
        public Greed(bool useAllRules)
        {
            _ruleSet.Add(new SingleDieRule(new DieValue(1), 100));
            _ruleSet.Add(new SingleDieRule(new DieValue(5), 50));
            _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(3), new DieValue(1), 1000));
            if (useAllRules)
            {
                _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(4), new DieValue(1), 2000));
                _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(5), new DieValue(1), 4000));
                _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(6), new DieValue(1), 8000));
                _ruleSet.Add(new StraightRule());
                _ruleSet.Add(new ThreePairsRule());
            }
            for (int i = 2; i < 7; i++)
            {
                _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(3), new DieValue(i), i * 100));
                if (useAllRules)
                {
                    _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(4), new DieValue(i), i * 200));
                    _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(5), new DieValue(i), i * 400));
                    _ruleSet.Add(new SetOfDiceRule(new RuleSetSize(6), new DieValue(i), i * 800));
                }
            }
        }

        public void AddScoringRule(IRule rule)
        {
            _ruleSet.Add(rule);
        }

        public int Score(int[] roles)
        {
            int score = 0;
            var remainingDice = new List<int>(roles);
            var bestRule = _ruleSet.BestRule(remainingDice.ToArray());
            var result = bestRule.Eval(remainingDice.ToArray());

            while (result.Score > 0)
            {
                foreach (var die in result.DiceUsed)
                {
                    remainingDice.Remove(die);
                }

                rulesUsed.Add(result);
                score += result.Score;

                bestRule = _ruleSet.BestRule(remainingDice.ToArray());
                result = bestRule.Eval(remainingDice.ToArray());
            }

            return score;
        }

        public IEnumerable<ScoreResult> RulesUsed => rulesUsed;
    }
}
