using System;
using System.Collections.Generic;
using GreedKataGame.Presentation.Implementation.Commands;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation
{
    public class UserInterface : IUserInterface
    {
        private ICommand _currentCommand;

        public UserInterface(IEnumerable<IGameOption> gameOptions)
        {
            _currentCommand = new ChooseDiceCommand(gameOptions);
        }

        public void ExecuteCurrentCommand()
        {
            ICommandResult commandResult = _currentCommand.Execute();
            _currentCommand = commandResult.NextCommand;
        }

        public bool HasCommandToExecute()
        {
            return !(_currentCommand is DoNothingCommand);
        }
    }
}
