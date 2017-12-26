using System.Collections.Generic;
using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.CommandResults
{
    public class InvalidGameOptionChosen : ICommandResult
    {
        private readonly IEnumerable<IGameOption> gameOptions;

        public InvalidGameOptionChosen(IEnumerable<IGameOption> gameOptions)
        {
            this.gameOptions = gameOptions;
        }

        public ICommand NextCommand => new InvalidOptionCommand(gameOptions);
    }
}
