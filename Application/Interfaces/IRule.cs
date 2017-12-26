using System;
using System.Collections.Generic;
using System.Linq;
using GreedKataGame.Application.Models;

namespace GreedKataGame.Application.Implementation
{
    public interface IRule
    {
        string Description { get; }
        ScoreResult Eval(int[] dice);
    }
}
