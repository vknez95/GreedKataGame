using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation.Rules
{
    public class RuleSet
    {
        private List<IRule> _rules = new List<IRule>();
        
        public IRule BestRule(int[] dice)
        {
            List<ScoreResult> resultByScore = new List<ScoreResult>();

            foreach (var rule in _rules)
            {
                var result = rule.Eval(dice);
                resultByScore.Add(result);
            }
            
            return resultByScore.OrderByDescending(result => result.Score).First().RuleUsed;
        }

        public void Add(IRule rule)
        {
            _rules.Add(rule);
        }
    }
}
