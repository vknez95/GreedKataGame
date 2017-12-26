using System.Collections.Generic;
using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.CommandResults
{
    public class ChooseDiceOption : ICommandResult
    {
        private readonly IEnumerable<IGameOption> gameOptions;

        public ChooseDiceOption(IEnumerable<IGameOption> gameOptions)
        {
            this.gameOptions = gameOptions;
        }

        public ICommand NextCommand => new ChooseDiceCommand(gameOptions);
    }
}
