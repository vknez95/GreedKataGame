using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKataGame.Presentation.Interfaces
{
    public interface IApplicationServices
    {
        IEnumerable<string> GetScoringRules();

        int CalculateScore();

        IEnumerable<string> RulesUsed { get; }

        int[] RollDice();

        string RolledDiceOutput { get; }
    }
}
