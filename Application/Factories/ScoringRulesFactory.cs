using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKataGame.Application.Factories
{
    public class ScoringRulesFactory
    {
        public IEnumerable<string> CreateRules(char optionId)
        {
            if (optionId == 'a')
            {
                return fiveDiceRules();
            }
            else if (optionId == 'b')
            {
                return sixDiceRules();
            }
            else
            {
                return new List<string>();
            }
        }

        private IEnumerable<string> fiveDiceRules()
        {
            return new List<string>()
            {
                "A single one (100)",
                "A single five (50)",
                "Triple ones [1,1,1] (1000)",
                "Triple twos [2,2,2] (200)",
                "Triple threes [3,3,3] (300)",
                "Triple fours [4,4,4] (400)",
                "Triple fives [5,5,5] (500)",
                "Triple sixes [6,6,6] (600)"
            };
        }

        private IEnumerable<string> sixDiceRules()
        {
            var rules = fiveDiceRules().ToList();

            rules.AddRange(new List<string>()
            {
                "Four-of-a-Kind [x,x,x,x]: Multiply Triple socre by 2 (4 2's should be 400)",
                "Five-of-a-Kind [x,x,x,x,x]: Multiply Triple score by 4 (5 2's should be 800)",
                "Six-of-a-Kind [x,x,x,x,x,x]: Multiply Triplw score by 8 (6 2's should be 1600)",
                "Three Pairs [x,x,y,y,z,z]: 800",
                "Straight [1,2,3,4,5,6]: 1200"
            });

            return rules;
        }
    }
}
