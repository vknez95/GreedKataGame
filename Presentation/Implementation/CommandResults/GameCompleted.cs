using System.Collections.Generic;
using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.CommandResults
{
    public class GameCompleted : ICommandResult
    {
        private readonly IDiceOption diceOption;

        public GameCompleted(IDiceOption diceOption)
        {
            this.diceOption = diceOption;
        }

        public ICommand NextCommand => new ContinueToPlayCommand(diceOption);
    }
}
