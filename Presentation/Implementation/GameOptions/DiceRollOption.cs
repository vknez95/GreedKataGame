using System.Collections.Generic;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.GameOptions
{
    public class DiceRollOption : IDiceOption
    {
        private readonly char id;
        private readonly string description;
        private readonly int diceNumber;

        public DiceRollOption(char id, string description, int diceNumber)
        {
            this.id = id;
            this.description = description;
            this.diceNumber = diceNumber;
        }

        public char Id => id;

        public string Description => description;

        public bool IsExitOption => false;

        public int DiceNumber => diceNumber;

        public bool UseAllRules => diceNumber == 6;
    }
}
