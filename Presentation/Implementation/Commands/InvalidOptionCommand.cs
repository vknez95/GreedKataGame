using System;
using System.Collections.Generic;
using GreedKataGame.Presentation.Implementation.CommandResults;
using GreedKataGame.Presentation.Interfaces;

namespace GreedKataGame.Presentation.Implementation.Commands
{
    internal class InvalidOptionCommand : ICommand
    {
        private readonly IEnumerable<IGameOption> gameOptions;

        public InvalidOptionCommand(IEnumerable<IGameOption> gameOptions)
        {
            this.gameOptions = gameOptions;
        }
        
        public ICommandResult Execute()
        {
            Console.WriteLine("\nInvalid option chosen!\n");
            Console.Write("Press any key to continue...");
            Console.ReadKey(false);

            return new ChooseDiceOption(gameOptions);
        }
    }
}
