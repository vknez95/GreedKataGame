using System.Collections.Generic;

namespace GreedKataGame.Presentation.Interfaces
{
    public interface IDiceOption : IGameOption
    {
        bool UseAllRules { get; }
        int DiceNumber { get; }
    }
}