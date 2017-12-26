using System;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class DoNothingCommand: ICommand
    {
        public ICommandResult Execute()
        {
            throw new InvalidOperationException();
        }
    }
}
