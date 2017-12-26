using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.CommandResults
{
    public class NoResult : ICommandResult
    {
        public ICommand NextCommand => new DoNothingCommand();
    }
}
